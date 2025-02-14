using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace XChartsDemo
{
    public enum ChartType
    {
        Buildin,
        Extend,
        Widget,
        Component,
        Homepage
    }

    [System.Serializable]
    public class ChartModule
    {
        [SerializeField] private string m_Name = "Name";
        [SerializeField] private string m_SubName = "SubName";
        [SerializeField] private ChartType m_Type = ChartType.Buildin;
        [SerializeField] private bool m_Selected;
        [SerializeField] private List<GameObject> m_ChartPrefabs = new List<GameObject>();
        [SerializeField] private List<string> m_ChartPrefabNames = new List<string>();

        private Dictionary<int, ChartThumb> m_RuntimeChartThumbs = new Dictionary<int, ChartThumb>();
        public string name { get { return m_Name; } }
        public string subName { get { return m_SubName; } }
        public bool select { get { return m_Selected; } set { m_Selected = value; } }
        public ChartType type { get { return m_Type; } }
        public List<GameObject> chartPrefabs { get { return m_ChartPrefabs; } }
        public List<string> chartPrefabNames { get { return m_ChartPrefabNames; } }
        public Dictionary<int, ChartThumb> chartThumbs { get { return m_RuntimeChartThumbs; } }

        public GameObject panel { get; set; }
        public Button button { get; set; }
        public int index { get; internal set; }
        internal int initedCount { get; set; }
        internal bool inited { get { return initedCount >= chartPrefabs.Count; } }
        internal bool runtimeSelected { get; set; }

        public ChartThumb GetThumb(int index)
        {
            if (chartThumbs.ContainsKey(index))
            {
                return chartThumbs[index];
            }
            else
                return null;
        }

        public string GetPrefabName(int index)
        {
            if (index >= 0 && index < m_ChartPrefabNames.Count)
                return m_ChartPrefabNames[index];
            else
                return "";
        }

        public void SyncPrefabNames()
        {
            m_ChartPrefabNames.Clear();
            int count = 0;
            foreach (var prefab in m_ChartPrefabs)
            {
                if (prefab != null)
                {
                    m_ChartPrefabNames.Add(prefab.name);
                    count++;
                }
            }
            Debug.Log("SyncPrefabNames count:" + name + " " + count);
        }

        public void RemoveMissingPrefab()
        {
            for (int i = m_ChartPrefabs.Count - 1; i >= 0; i--)
            {
                if (m_ChartPrefabs[i] == null)
                {
                    m_ChartPrefabs.RemoveAt(i);
                }
            }
            SyncPrefabNames();
        }
    }

    [CreateAssetMenu(menuName = "CreateDemoConfig")]
    public class DemoConfig : ScriptableObject
    {
#pragma warning disable 0649
        [SerializeField] private float m_LeftWidth = 150;
        [SerializeField] private float m_ButtonHeight = 60;
        [SerializeField] private Color m_ButtonNormalColor;
        [SerializeField] private Color m_ButtonSelectedColor;
        [SerializeField] private Color m_ButtonHighlightColor;
        [SerializeField] private bool m_DarkMode = false;
        [SerializeField] public int selectedModuleIndex = -1;
        [SerializeField] private int m_ExtendedChartImgColumn = 5;
        [SerializeField] private GameObject m_EmptyChartPrefab;
        [SerializeField] private List<ChartModule> m_ChartModules = new List<ChartModule>();
#pragma warning restore 0649

        public float leftWidth { get { return m_LeftWidth; } }
        public float buttonHeight { get { return m_ButtonHeight; } }
        public Color buttonNormalColor { get { return m_ButtonNormalColor; } }
        public Color buttonSelectedColor { get { return m_ButtonSelectedColor; } }
        public Color buttonHighlightColor { get { return m_ButtonHighlightColor; } }
        public bool darkMode { get { return m_DarkMode; } }
        public List<ChartModule> chartModules { get { return m_ChartModules; } }
        public int extendedChartImgColumn { get { return m_ExtendedChartImgColumn; } }
        public GameObject emptyChartPrefab { get { return m_EmptyChartPrefab; } }

        public void Init()
        {
            foreach (var module in m_ChartModules)
            {
                module.SyncPrefabNames();
            }
        }

        public void RemoveMissingPrefab()
        {
            foreach (var module in m_ChartModules)
            {
                module.RemoveMissingPrefab();
            }
        }
    }
}