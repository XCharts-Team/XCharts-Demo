using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    internal class DemoView : MonoBehaviour
    {
        [SerializeField] private int m_TabIndex = 0;
        [SerializeField] private DemoConfig m_Config = null;
        private PanelChart m_PanelChart;
        private List<Button> m_TabButtonList = new List<Button>();

        private void Awake()
        {
            m_PanelChart = gameObject.GetComponentInChildren<PanelChart>();
            m_PanelChart.config = m_Config;
            UIUtil.SetText(gameObject, XChartsMgr.fullVersion, "panel_top/logo/version");
            var tab1 = UIUtil.SetButton(gameObject, "panel_top/menubar/btn_Buildin", delegate () { SwitchTab(0); });
            var tab2 = UIUtil.SetButton(gameObject, "panel_top/menubar/btn_ExtraChart", delegate () { SwitchTab(1); });
            var tab3 = UIUtil.SetButton(gameObject, "panel_top/menubar/btn_Component", delegate () { SwitchTab(2); });
            var tab4 = UIUtil.SetButton(gameObject, "panel_top/menubar/btn_ExtraWidget", delegate () { SwitchTab(3); });
            m_TabButtonList.Clear();
            m_TabButtonList.Add(tab1);
            m_TabButtonList.Add(tab2);
            m_TabButtonList.Add(tab3);
            m_TabButtonList.Add(tab4);
            if (m_TabIndex >= m_TabButtonList.Count)
                m_TabIndex = 0;
            UpdateTabButtonStatus();
        }

        private void SwitchTab(int tabIndex)
        {
            m_TabIndex = tabIndex;
            UpdateTabButtonStatus();
            if (m_TabIndex == 0)
                m_PanelChart.SwitchTab(ChartType.Buildin);
            else if (m_TabIndex == 1)
                m_PanelChart.SwitchTab(ChartType.Extend);
            else if (m_TabIndex == 2)
                m_PanelChart.SwitchTab(ChartType.Component);
            else if (m_TabIndex == 3)
                m_PanelChart.SwitchTab(ChartType.Widget);
        }

        private void UpdateTabButtonStatus()
        {
            for (int i = 0; i < m_TabButtonList.Count; i++)
            {
                if (i == m_TabIndex)
                {
                    UIUtil.SetButtonColor(m_TabButtonList[i], m_Config.buttonSelectedColor,
                        m_Config.buttonSelectedColor, m_Config.buttonSelectedColor);
                }
                else
                {
                    UIUtil.SetButtonColor(m_TabButtonList[i], m_Config.buttonNormalColor,
                        m_Config.buttonNormalColor, m_Config.buttonHighlightColor);
                }
            }
        }
    }
}