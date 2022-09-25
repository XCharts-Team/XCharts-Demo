using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class PanelChart : MonoBehaviour
    {
        [SerializeField] public int selectedModuleIndex = -1;
        [SerializeField] public DemoConfig config;

        private GameObject m_BtnClone;
        private GameObject m_ThumbClone;
        private GameObject m_ListClone;
        private Transform m_ChartListParent;
        private ThemeType m_SelectedTheme;
        private GameObject m_SelectedPanel;
        private ChartThumb m_SelectedThumb;
        private float m_LastCheckLeftWidth;

        private Toggle m_DarkThemeToggle;

        private ScrollRect m_ScrollRect;
        private Mask m_Mark;
        private GameObject m_DetailRoot;
        private GameObject m_DetailChartRoot;
        private Image m_DetailChartDescBackground;
        private float m_LastInitedThumbTime = 0;
        private ChartType m_ChartType = ChartType.Buildin;

        void Awake()
        {
            m_SelectedTheme = config.darkMode ? ThemeType.Dark : ThemeType.Default;
            Init();
        }

        void Init()
        {
            m_ScrollRect = transform.Find("chart_list").GetComponent<ScrollRect>();
            m_ChartListParent = transform.Find("chart_list/Viewport");
            m_Mark = m_ChartListParent.GetComponent<Mask>();
            m_Mark.enabled = true;
            m_ThumbClone = transform.Find("clone_thumb").gameObject;
            m_ThumbClone.SetActive(false);
            m_ListClone = transform.Find("clone_list").gameObject;
            m_ListClone.SetActive(false);
            m_DetailRoot = transform.Find("chart_detail").gameObject;
            m_DetailRoot.SetActive(false);
            m_DetailChartRoot = transform.Find("chart_detail/chart").gameObject;
            m_DetailChartDescBackground = transform.Find("chart_detail/desc").GetComponent<Image>();
            UIUtil.SetButton(gameObject, "chart_detail/btn_next", delegate() { NextDetailChart(); });
            UIUtil.SetButton(gameObject, "chart_detail/btn_last", delegate() { LastDetailChart(); });
            InitThemeButton();
            InitModuleButton();
            InitChartList(true);
            InitSize();
            CheckDetailBackgound();
        }

        void InitSize()
        {
            UIUtil.SetRectTransformWidth(transform, config.leftWidth, "chart_btn");
            UIUtil.SetRectTransformLeft(transform, config.leftWidth, "chart_list");
            UIUtil.SetRectTransformLeft(transform, config.leftWidth, "chart_title");
            UIUtil.SetGridLayoutGroup(transform, new Vector2(config.leftWidth, config.buttonHeight), new Vector2(0, 0), "chart_btn/Viewport/content");
            foreach (var module in config.chartModules)
            {
                SetChartRootInfo(module);
            }
        }

        private void SetChartRootInfo(ChartModule module)
        {
            m_SelectedPanel = module.panel;
            if (m_SelectedPanel == null) return;
            var grid = m_SelectedPanel.GetComponent<GridLayoutGroup>();
            var hig = Mathf.CeilToInt(m_SelectedPanel.transform.childCount * 1f / 5) * (grid.cellSize.y + grid.spacing.y);
            UIUtil.SetRectTransformHeight(m_SelectedPanel.transform, hig);
        }

        void ResetParam()
        {
            var charts = transform.GetComponentsInChildren<BaseChart>();
            foreach (var chart in charts)
            {
                chart.RebuildChartObject();
            }
        }

        void Update()
        {
#if UNITY_EDITOR
            if (config.chartModules.Count <= 0) return;
            if (!Application.isPlaying) m_Mark.enabled = false;

            if (m_LastCheckLeftWidth != config.leftWidth)
            {
                m_LastCheckLeftWidth = config.leftWidth;
                InitSize();
            }
#endif 
            if (Application.isPlaying)
            {
                if (Time.time - m_LastInitedThumbTime > 0.1f)
                {
                    m_LastInitedThumbTime = Time.time;
                    foreach (var module in config.chartModules)
                    {
                        CheckInitChartThumb(module);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                NextDetailChart();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                LastDetailChart();
            }
        }

        private void CheckDetailBackgound()
        {
            if (!m_DetailChartRoot.activeInHierarchy) return;
            var pos1 = m_DetailChartDescBackground.transform.localPosition;
            var pos2 = m_DetailChartRoot.transform.localPosition;
            m_DetailChartDescBackground.enabled = Mathf.Abs((pos2.y - pos1.y)) < 445;
        }

        public void SwitchTab(ChartType type)
        {
            selectedModuleIndex = -1;
            m_ChartType = type;
            InitModuleButton();
            InitChartList(false);
            foreach (var module in config.chartModules)
            {
                if (type == module.type)
                {
                    ClickModule(module);
                    break;
                }
            }
        }

        public void InitModuleButton()
        {
            var btnPanel = transform.Find("chart_btn/Viewport/content");
            m_BtnClone = transform.Find("clone_btn").gameObject;
            m_BtnClone.SetActive(false);
            for (int i = 0; i < btnPanel.childCount; i++)
            {
                btnPanel.GetChild(i).gameObject.SetActive(false);
            }
            var totalHeight = 0f;
            for (int i = 0; i < config.chartModules.Count; i++)
            {
                var module = config.chartModules[i];
                module.index = i;
                var btnName = module.name;
                GameObject btn;
                if (btnPanel.Find(btnName))
                {
                    btn = btnPanel.Find(btnName).gameObject;
                    btn.name = btnName;
                    ChartHelper.SetActive(btn, true);
                }
                else
                {
                    btn = GameObject.Instantiate(m_BtnClone);

                    btn.name = btnName;
                    btn.transform.SetParent(btnPanel);
                    btn.transform.localPosition = Vector3.zero;
                }
                btn.SetActive(module.type == m_ChartType);
                totalHeight += config.buttonHeight;
                btn.transform.localScale = Vector3.one;
                module.button = btn.GetComponent<Button>();
                module.button.transform.Find("Text").GetComponent<Text>().text = module.name.Replace("\\n", "\n");
                module.button.transform.Find("SubText").GetComponent<Text>().text = module.subName.Replace("\\n", "\n");
                module.button.onClick.AddListener(delegate()
                {
                    ClickModule(module);
                });
            }
            UIUtil.SetRectTransformHeight(btnPanel.transform, totalHeight);
            for (int i = 0; i < config.chartModules.Count; i++)
            {
                var module = config.chartModules[i];
                module.index = i;
                module.runtimeSelected = module.select;
                if (module.runtimeSelected)
                {
                    ClickModule(module);
                    break;
                }
            }
        }

        public void InitChartList(bool firstInit)
        {
            foreach (var module in config.chartModules)
            {
                if (module.panel == null)
                {
                    var panelTrans = m_ChartListParent.Find(module.name);
                    if (panelTrans == null)
                        module.panel = UIUtil.Instantiate(m_ListClone, m_ChartListParent, module.name);
                    else
                        module.panel = panelTrans.gameObject;
                    UIUtil.ResetRectTransform(module.panel.transform);
                }
                if (firstInit)
                    module.initedCount = 0;
                module.panel.SetActive(module.runtimeSelected);
                InitChartList(module, firstInit);
            }
        }

        public void InitChartList(ChartModule module, bool firstInit)
        {
            module.chartThumbs.Clear();
            if (!Application.isPlaying)
            {
                if (firstInit) ChartHelper.DestroyAllChildren(module.panel.transform);
                else UIUtil.SetActiveAllChildren(module.panel, false);
                module.panel.SetActive(module.select);

                for (int i = 0; i < module.chartPrefabs.Count; i++)
                    InitChartThumb(module, module.chartPrefabs[i], i);
            }
            else if (!module.inited)
            {
                if (firstInit) ChartHelper.DestroyAllChildren(module.panel.transform);
                else UIUtil.SetActiveAllChildren(module.panel, false);
            }
        }

        private void CheckInitChartThumb(ChartModule module)
        {
            if (selectedModuleIndex != module.index) return;
            if (module.initedCount >= module.chartPrefabs.Count) return;
            var prefab = module.chartPrefabs[module.initedCount];
            InitChartThumb(module, prefab, module.initedCount);
            module.initedCount++;
            SetChartRootInfo(module);
        }

        private void InitChartThumb(ChartModule module, GameObject prefab, int index)
        {
            if (prefab != null)
            {
                GameObject obj;
                if (module.panel.transform.Find(prefab.name))
                    obj = module.panel.transform.Find(prefab.name).gameObject;
                else
                    obj = UIUtil.Instantiate(m_ThumbClone, module.panel.transform, prefab.name);
                obj.SetActive(true);
                var thumb = ChartHelper.GetOrAddComponent<ChartThumb>(obj);
                module.chartThumbs.Add(thumb);
                thumb.index = index;
                thumb.BindPrefab(prefab);
                thumb.AddBtnListener(delegate()
                {
                    m_SelectedPanel = m_DetailChartRoot;
                    m_SelectedThumb = thumb;
                    ChartHelper.DestroyAllChildren(m_DetailChartRoot.transform);
                    UIUtil.Instantiate(prefab, m_DetailChartRoot.transform, prefab.name);
                    var names = prefab.name.Split('_');
                    UIUtil.SetText(m_DetailRoot, names[1], "desc/Text");
                    UIUtil.SetText(m_DetailRoot, names[2], "desc/Text2");
                    m_DetailRoot.SetActive(true);
                    module.panel.SetActive(false);
                    thumb.OnPointerExit(null);
                    UpdateChartTheme(m_SelectedTheme);
                    CheckDetailBackgound();
                    CheckArrowButton(module, thumb);
                });
            }
        }

        private void NextDetailChart()
        {
            if (m_SelectedThumb == null) return;
            var module = config.chartModules[selectedModuleIndex];
            if (module == null) return;
            var thumb = module.GetThumb(m_SelectedThumb.index + 1);
            if (thumb != null)
            {
                thumb.Click();
                CheckArrowButton(module, thumb);
            }
        }

        private void LastDetailChart()
        {
            if (m_SelectedThumb == null) return;
            var module = config.chartModules[selectedModuleIndex];
            if (module == null) return;
            var thumb = module.GetThumb(m_SelectedThumb.index - 1);
            if (thumb != null)
            {
                thumb.Click();
                CheckArrowButton(module, thumb);
            }
        }

        private void CheckArrowButton(ChartModule module, ChartThumb thumb)
        {
            if (thumb == null)
            {
                UIUtil.SetActive(gameObject, false, "chart_detail/btn_next");
                UIUtil.SetActive(gameObject, false, "chart_detail/btn_last");
            }
            else
            {
                UIUtil.SetActive(gameObject, module.GetThumb(thumb.index + 1) != null, "chart_detail/btn_next");
                UIUtil.SetActive(gameObject, module.GetThumb(thumb.index - 1) != null, "chart_detail/btn_last");
            }

        }

        void ClickModule(ChartModule selectedModule)
        {
            var lastIndex = selectedModuleIndex;
            if (selectedModuleIndex >= 0)
            {
                config.chartModules[selectedModuleIndex].runtimeSelected = false;
            }
            selectedModuleIndex = selectedModule.index;
            selectedModule.runtimeSelected = true;
            m_DetailRoot.SetActive(false);
            foreach (var module in config.chartModules)
            {
                if (module.index != selectedModuleIndex)
                {
                    UIUtil.SetButtonColor(module.button, config.buttonNormalColor, config.buttonNormalColor, config.buttonHighlightColor);
                    if (module.panel != null)
                        module.panel.SetActive(false);
                }
                else
                {
                    UIUtil.SetButtonColor(module.button, config.buttonSelectedColor, config.buttonSelectedColor, config.buttonSelectedColor);
                    if (module.panel != null)
                        module.panel.SetActive(true);
                }
            }
            if (selectedModule.panel != null)
                m_ScrollRect.content = selectedModule.panel.GetComponent<RectTransform>();
            SetChartRootInfo(selectedModule);
            UpdateChartTheme(m_SelectedTheme);
            if (lastIndex != selectedModuleIndex)
                ResetChartAnimation();
        }

        void InitThemeButton()
        {
            m_DarkThemeToggle = transform.Find("chart_theme/dark").GetComponent<Toggle>();
            m_DarkThemeToggle.isOn = config.darkMode;

            m_DarkThemeToggle.onValueChanged.AddListener(delegate(bool flag)
            {
                m_SelectedTheme = flag ? ThemeType.Dark : ThemeType.Default;
                UpdateChartTheme(m_SelectedTheme);
            });
        }

        void UpdateChartTheme(ThemeType theme)
        {
            m_DetailChartDescBackground.color = m_SelectedTheme == ThemeType.Dark?(Color) new Color32(16, 12, 42, 255) : Color.white;
            var charts = (m_SelectedPanel == null ? transform : m_SelectedPanel.transform).GetComponentsInChildren<BaseChart>();
            foreach (var chart in charts)
            {
                chart.UpdateTheme(theme);
            }
        }

        void ResetChartAnimation()
        {
            var charts = (m_SelectedPanel == null ? transform : m_SelectedPanel.transform).GetComponentsInChildren<BaseChart>();
            foreach (var chart in charts)
            {
                chart.AnimationReset();
                chart.AnimationFadeIn();
            }
        }
    }
}