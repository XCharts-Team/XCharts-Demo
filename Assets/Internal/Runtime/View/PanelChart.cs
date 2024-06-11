using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    //[ExecuteInEditMode]
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
            UIUtil.SetButton(gameObject, "chart_detail/btn_next", delegate () { NextDetailChart(); });
            UIUtil.SetButton(gameObject, "chart_detail/btn_last", delegate () { LastDetailChart(); });
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
            UIUtil.SetGridLayoutGroup(transform, new Vector2(config.leftWidth, config.buttonHeight), new Vector2(0, 2), "chart_btn/Viewport/content");
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
                var active = module.type == m_ChartType;
                btn.SetActive(active);
                if (active)
                {
                    totalHeight += config.buttonHeight;
                }
                btn.transform.localScale = Vector3.one;
                module.button = btn.GetComponent<Button>();
                module.button.transform.Find("Text").GetComponent<Text>().text = module.name.Replace("\\n", "\n");
                module.button.transform.Find("SubText").GetComponent<Text>().text = module.subName.Replace("\\n", "\n");
                module.button.onClick.AddListener(delegate ()
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
                module.panel.SetActive(module.runtimeSelected && m_ChartType != ChartType.Homepage);
                InitChartList(module, firstInit);
            }
        }

        public void InitChartList(ChartModule module, bool firstInit)
        {
            module.chartThumbs.Clear();
            if (!Application.isPlaying)
            {
                // if (firstInit) ChartHelper.DestroyAllChildren(module.panel.transform);
                // else UIUtil.SetActiveAllChildren(module.panel, false);
                UIUtil.SetActiveAllChildren(module.panel, false);
                module.panel.SetActive(module.select);

                for (int i = 0; i < module.chartPrefabs.Count; i++)
                    InitChartThumb(module, module.chartPrefabs[i], i);
            }
            else if (!module.inited)
            {
                // if (firstInit) ChartHelper.DestroyAllChildren(module.panel.transform);
                // else UIUtil.SetActiveAllChildren(module.panel, false);
                UIUtil.SetActiveAllChildren(module.panel, false);
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
            if (module.panel != null)
            {
                if (prefab == null)
                {
                    prefab = config.emptyChartPrefab;
                }
                var prefabName = module.GetPrefabName(index);
                if (string.IsNullOrEmpty(prefabName))
                    prefabName = string.Format("{1}{0}_{1}_{2}", index, module.name, module.subName);

                GameObject obj;
                if (prefab == null)
                {
                    obj = UIUtil.Instantiate(m_ThumbClone, module.panel.transform, prefabName);
                }
                else
                {
                    if (module.panel.transform.Find(prefabName))
                        obj = module.panel.transform.Find(prefabName).gameObject;
                    else
                        obj = UIUtil.Instantiate(m_ThumbClone, module.panel.transform, prefabName);
                }
                obj.SetActive(true);
                var thumb = ChartHelper.EnsureComponent<ChartThumb>(obj);
                module.chartThumbs.Add(thumb);
                thumb.index = index;
                thumb.BindPrefab(prefab, prefabName);
                thumb.AddBtnListener(delegate ()
                {
                    m_SelectedPanel = m_DetailChartRoot;
                    m_SelectedThumb = thumb;
                    CheckArrowButton(module, thumb);
                    if (prefab == null) return;
                    ChartHelper.DestroyAllChildren(m_DetailChartRoot.transform);
                    UIUtil.Instantiate(prefab, m_DetailChartRoot.transform, prefabName);
                    var names = prefabName.Split('_');
                    UIUtil.SetActive(m_DetailRoot, m_SelectedTheme == ThemeType.Dark, "desc/dark");
                    UIUtil.SetActive(m_DetailRoot, m_SelectedTheme != ThemeType.Dark, "desc/default");
                    var showTitle = true;
                    if (names.Length == 4)
                    {
                        showTitle = names[3] == "1";
                    }
                    showTitle = false; //暂时不显示title
                    UIUtil.SetActive(m_DetailRoot, showTitle, "desc");
                    UIUtil.SetText(m_DetailRoot, names[1], "desc/dark/Text");
                    UIUtil.SetText(m_DetailRoot, names[2], "desc/dark/Text2");
                    UIUtil.SetText(m_DetailRoot, names[1], "desc/default/Text");
                    UIUtil.SetText(m_DetailRoot, names[2], "desc/default/Text2");
                    UIUtil.SetRectTransformWidth(m_DetailRoot.transform, prefab.GetComponent<RectTransform>().sizeDelta.x, "desc");
                    m_DetailRoot.SetActive(true);
                    module.panel.SetActive(false);
                    thumb.OnPointerExit(null);
                    UpdateChartTheme(m_SelectedTheme);
                    ResetChartAnimation();
                    CheckDetailBackgound();
                });
            }
            else
            {
                Debug.LogError("module.panel is null:" + module.name + "," + index);
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
                m_SelectedThumb = thumb;
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
            m_DetailRoot?.SetActive(false);
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
            if (selectedModule.panel != null && m_ScrollRect != null)
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

            m_DarkThemeToggle.onValueChanged.AddListener(delegate (bool flag)
            {
                m_SelectedTheme = flag ? ThemeType.Dark : ThemeType.Default;
                UpdateChartTheme(m_SelectedTheme);
                //ExportExtendedChartImgToRepo();
            });
        }

        void UpdateChartTheme(ThemeType theme)
        {
            m_DetailChartDescBackground.color = m_SelectedTheme == ThemeType.Dark ? (Color)new Color32(16, 12, 42, 255) : Color.white;
            UIUtil.SetActive(m_DetailRoot, m_SelectedTheme == ThemeType.Dark, "desc/dark");
            UIUtil.SetActive(m_DetailRoot, m_SelectedTheme != ThemeType.Dark, "desc/default");
            var charts = (m_SelectedPanel == null ? transform : m_SelectedPanel.transform).GetComponentsInChildren<BaseChart>();
            foreach (var chart in charts)
            {
                chart.UpdateTheme(theme);
            }
            var widgets = (m_SelectedPanel == null ? transform : m_SelectedPanel.transform).GetComponentsInChildren<UIComponent>();
            foreach (var chart in widgets)
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

        void ExportExtendedChartImgToRepo()
        {
            StartCoroutine(ExportExtendedChartImgToRepoSync());
        }

        private IEnumerator ExportExtendedChartImgToRepoSync()
        {
            yield return new WaitForEndOfFrame();
            var canvas = GameObject.Find("Canvas").transform.GetComponent<Canvas>();
            if (m_SelectedPanel == null) yield return null;
            //foreach panel child
            var sb = new System.Text.StringBuilder();
            var tableColumn = config.extendedChartImgColumn;
            for (int i = 0; i < tableColumn; i++)
            {
                sb.Append("|");
            }
            sb.Append("|\n");
            for (int i = 0; i < tableColumn; i++)
            {
                sb.Append("| :--: ");
            }
            sb.Append("|\n");
            var serieName = "";
            var repoLocalPath = "";
            for (int i = 0; i < m_SelectedPanel.transform.childCount; i++)
            {
                var child = m_SelectedPanel.transform.GetChild(i);
                var rectTransform = child.GetComponent<RectTransform>();
                var temp = rectTransform.name.Split('_');
                serieName = temp[0].Substring(0, temp[0].Length - 2);
                repoLocalPath = string.Format("{0}/../../XCharts/Assets/XCharts-{1}Chart", Application.dataPath, serieName);
                if (!Directory.Exists(repoLocalPath))
                {
                    Debug.LogError("repoLocalPath not exist: " + repoLocalPath);
                    continue;
                }
                var imgPath = repoLocalPath + "/Documentation~/zh/img";
                if (!Directory.Exists(imgPath))
                {
                    Directory.CreateDirectory(imgPath);
                }
                var path = string.Format("{0}/{1}.png", imgPath, temp[0]);
                path = Path.GetFullPath(path);
                ChartHelper.SaveAsImage(rectTransform, canvas, "png", path);

                var relativePath = "Documentation~/zh/img/" + temp[0] + ".png";
                sb.Append(string.Format("|![{0}]({1}) ", temp[0], relativePath));
                if (i > 0 && i % tableColumn == 0)
                {
                    sb.Append("|\n");
                }
            }
            if (sb[sb.Length - 1] != '\n')
                sb.Append("|\n");

            var readmePath = Path.GetFullPath(repoLocalPath + "/README.md");
            UpdateScreenshotInfoToReadme(readmePath, sb.ToString());
            Debug.LogError(sb.ToString());
        }

        private static void UpdateScreenshotInfoToReadme(string readmePath, string content)
        {
            if (!File.Exists(readmePath))
            {
                Debug.LogError("Can't find readme: " + readmePath);
                return;
            }
            var lines = File.ReadAllLines(readmePath);
            var lineStart = -1;
            var lineEnd = -1;

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.Contains("## 截图"))
                    lineStart = i;
                else if (line.Contains("## 许可"))
                    lineEnd = i - 1;
            }
            if (lineEnd < 0)
            {
                Debug.LogError("Can't find 【## 许可】in readme");
                return;
            }
            var sb = new System.Text.StringBuilder();
            if (lineStart < 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == lineEnd)
                        sb.AppendFormat("\n## 截图\n\n{0}\n", content);
                    else
                        sb.AppendLine(lines[i]);
                }
            }
            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == lineStart)
                        sb.AppendFormat("## 截图\n\n{0}\n", content);
                    else if (i > lineStart && i <= lineEnd)
                        continue;
                    else
                        sb.AppendLine(lines[i]);
                }
            }

            File.WriteAllText(readmePath, sb.ToString());
        }
    }
}