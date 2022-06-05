using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace XChartsDemo
{
    public enum ChartType
    {
        Buildin,
        Extend
    }

    [System.Serializable]
    public class ChartModule
    {
        [SerializeField] private string m_Name = "Name";
        [SerializeField] private string m_SubName = "SubName";
        [SerializeField] private ChartType m_Type = ChartType.Buildin;
        [SerializeField] private bool m_Selected;
        [SerializeField] private bool m_Buildin;
        [SerializeField] private List<GameObject> m_ChartPrefabs = new List<GameObject>();

        public string name { get { return m_Name; } }
        public string subName { get { return m_SubName; } }
        public bool select { get { return m_Selected; } set { m_Selected = value; } }
        public ChartType type { get { return m_Type; } }
        public List<GameObject> chartPrefabs { get { return m_ChartPrefabs; } }
        public List<ChartThumb> chartThumbs = new List<ChartThumb>();

        public GameObject panel { get; set; }
        public Button button { get; set; }
        public int index { get; internal set; }
        internal int initedCount { get; set; }
        internal bool inited { get { return initedCount >= chartPrefabs.Count; } }
        internal bool runtimeSelected { get; set; }

        public ChartThumb GetThumb(int index)
        {
            if (index >= 0 && index < chartThumbs.Count)
                return chartThumbs[index];
            else
                return null;
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
        [SerializeField] private List<ChartModule> m_ChartModules = new List<ChartModule>();
#pragma warning restore 0649

        public float leftWidth { get { return m_LeftWidth; } }
        public float buttonHeight { get { return m_ButtonHeight; } }
        public Color buttonNormalColor { get { return m_ButtonNormalColor; } }
        public Color buttonSelectedColor { get { return m_ButtonSelectedColor; } }
        public Color buttonHighlightColor { get { return m_ButtonHighlightColor; } }
        public bool darkMode { get { return m_DarkMode; } }
        public List<ChartModule> chartModules { get { return m_ChartModules; } }
    }
}