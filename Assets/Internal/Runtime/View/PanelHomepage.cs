using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    // [ExecuteInEditMode]
    public class PanelHomepage : MonoBehaviour
    {
        [SerializeField] private float m_GridGap = 20f;
        private float m_LastGridGap = 0;

        void Awake()
        {
            InitChart();
            HideMissingChart();
        }

        void Update()
        {
            if (m_LastGridGap != m_GridGap)
            {
                m_LastGridGap = m_GridGap;
                InitChart();
            }
        }

        void InitChart()
        {
            var charts = GetComponentsInChildren<BaseChart>();
            foreach (var chart in charts)
            {
                foreach (var com in chart.components)
                {
                    if (com is Axis)
                    {
                        var axis = com as Axis;
                        axis.show = true;
                        axis.axisLine.show = (chart is ParallelChart);
                        axis.axisTick.show = false;
                        axis.axisLabel.show = false;
                    }
                    else if (com is Title)
                    {
                        (com as Title).show = false;
                    }
                    else if (com is Legend)
                    {
                        (com as Legend).show = false;
                    }
                    else if (com is RadarCoord)
                    {
                        (com as RadarCoord).axisName.show = false;
                    }
                    else if (com is GridCoord)
                    {
                        var grid = com as GridCoord;
                        grid.left = m_GridGap;
                        grid.right = m_GridGap;
                        grid.top = m_GridGap;
                        grid.bottom = m_GridGap;
                    }
                    else if (com is ParallelCoord)
                    {
                        var grid = com as ParallelCoord;
                        grid.left = m_GridGap;
                        grid.right = m_GridGap;
                        grid.top = m_GridGap;
                        grid.bottom = m_GridGap;
                    }
                }
            }
        }

        void HideMissingChart()
        {
            var objects = gameObject.transform.Find("Chart").GetComponentsInChildren<Transform>();
            foreach (var obj in objects)
            {
                if (obj.name.Contains("Missing"))
                    obj.gameObject.SetActive(false);
            }
        }
    }
}
