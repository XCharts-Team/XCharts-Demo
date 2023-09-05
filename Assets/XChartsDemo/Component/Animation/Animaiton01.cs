using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    public class Animaiton01 : MonoBehaviour
    {
        [SerializeField] private float m_Interval = 5f;
        [SerializeField] private bool m_FadeInAnimation = false;
        [SerializeField] private bool m_FadeOutAnimation = false;
        [SerializeField] private bool m_AdditionAnimation = false;
        [SerializeField] private bool m_ChangeAnimation = false;
        [SerializeField] private bool m_InteractAnimation = false;

        private BaseChart[] m_ChartList;
        private float m_LastTime;
        private int m_Count;
        private bool m_FadeOutFlag = true;

        void Awake()
        {
            m_ChartList = GetComponentsInChildren<BaseChart>();
        }

        void Update()
        {
            if (Time.time - m_LastTime > m_Interval)
            {
                m_LastTime = Time.time;
                m_Count++;
                if (m_FadeInAnimation || m_FadeOutAnimation)
                {
                    if (m_FadeOutFlag)
                    {
                        AnimationFadeIn();
                        m_FadeOutFlag = false;
                    }
                    else
                    {
                        AnimationFadeOut();
                        m_FadeOutFlag = true;
                    }
                }
                else if (m_AdditionAnimation)
                {
                    AnimationAddition();
                }
                else if (m_ChangeAnimation)
                {
                    AnimationChange();
                }
                else if (m_InteractAnimation)
                {
                    AnimationInteract();
                }
            }
        }

        void AnimationFadeIn()
        {
            if (!m_FadeInAnimation) return;
            foreach (var chart in m_ChartList)
            {
                chart.AnimationFadeIn();
            }
        }

        void AnimationFadeOut()
        {
            if (!m_FadeOutAnimation) return;
            foreach (var chart in m_ChartList)
            {
                chart.AnimationFadeOut();
            }
        }

        void AnimationAddition()
        {
            foreach (var chart in m_ChartList)
            {
                var xAxisList = chart.GetChartComponents<XAxis>();
                if (xAxisList != null)
                {
                    foreach (var com in xAxisList)
                    {
                        var xAxis = com as XAxis;
                        if (xAxis.type == Axis.AxisType.Category)
                        {
                            chart.AddXAxisData("x" + (xAxis.data.Count + 1));
                        }
                    }
                }
                foreach (var serie in chart.series)
                {
                    var xAxis = chart.GetChartComponent<XAxis>(serie.xAxisIndex);
                    AddSerieRandomData(chart, serie, xAxis);
                }
            }
        }

        void AnimationChange()
        {
            foreach (var chart in m_ChartList)
            {
                foreach (var serie in chart.series)
                {
                    UpdateSerieRandomData(chart, serie);
                }
            }
        }

        void AnimationInteract()
        {
            foreach (var chart in m_ChartList)
            {
                foreach (var serie in chart.series)
                {
                    var index = m_Count % serie.dataCount;
                    foreach (var serieData in serie.data)
                    {
                        serieData.context.highlight = serieData.index == index;
                        serieData.selected = serieData.index == index;
                    }
                    chart.TriggerTooltip(index);
                }
                chart.RefreshChart();
            }
        }

        void AddSerieRandomData(BaseChart chart, Serie serie, XAxis xAxis)
        {
            if (serie is Line || serie is Bar || serie is Scatter || serie is EffectScatter)
            {
                if (xAxis != null && xAxis.type == Axis.AxisType.Category)
                {
                    chart.AddData(serie.index, Random.Range(10, 90), "data" + serie.context.totalDataIndex);
                }
                else
                {
                    if (serie is Line)
                        chart.AddData(serie.index, serie.context.totalDataIndex, Random.Range(10, 90), "data" + serie.context.totalDataIndex);
                    else
                        chart.AddData(serie.index, Random.Range(10, 90), Random.Range(10, 90), "data" + serie.context.totalDataIndex);
                }
            }
            else if (serie is Ring)
            {
                chart.AddData(serie.index, Random.Range(10, 90), 100, "data" + serie.context.totalDataIndex);
            }
            else if (serie is Radar)
            {
                var list = new System.Collections.Generic.List<double>();
                for (int i = 0; i < 5; i++)
                    list.Add(Random.Range(10, 90));
                chart.AddData(serie.index, list, "data" + serie.context.totalDataIndex);
            }
            else if (serie is Candlestick)
            {
                var open = Random.Range(20, 60);
                var close = Random.Range(40, 90);
                var lowest = Random.Range(0, 50);
                var heighest = Random.Range(50, 100);
                chart.AddData(serie.index, serie.context.totalDataIndex, open, close, lowest, heighest);
            }
            else if (serie is Heatmap)
            {
                var yAxis = chart.GetChartComponent<YAxis>(serie.yAxisIndex);
                for (int i = 0; i < yAxis.data.Count; i++)
                {
                    chart.AddData(serie.index, xAxis.data.Count - 1, i, Random.Range(0, 150));
                }
            }
            else
            {
                chart.AddData(serie.index, Random.Range(10, 90), "data" + serie.context.totalDataIndex);
            }
        }

        void UpdateSerieRandomData(BaseChart chart, Serie serie)
        {
            var index = Random.Range(0, serie.dataCount);
            if (serie is Ring)
            {
                chart.UpdateData(serie.index, index, 0, Random.Range(10, 90));
            }
            else if (serie is Radar)
            {
                var dimension = Random.Range(0, 5);
                chart.UpdateData(serie.index, index, dimension, Random.Range(10, 90));
            }
            else if (serie is Heatmap)
            {
                var xAxis = chart.GetChartComponent<XAxis>();
                var yAxis = chart.GetChartComponent<YAxis>();
                var xIndex = Random.Range(0, xAxis.data.Count);
                var yIndex = Random.Range(0, yAxis.data.Count);
                chart.UpdateData(serie.index, xIndex, yIndex, Random.Range(10, 90));
            }
            else if (serie is Candlestick)
            {
                var open = Random.Range(20, 60);
                var close = Random.Range(40, 90);
                var lowest = Random.Range(0, 50);
                var heighest = Random.Range(50, 100);
                chart.UpdateData(serie.index, index, new List<double> { open, close, lowest, heighest });
            }
            else
            {
                chart.UpdateData(serie.index, index, Random.Range(10, 90));
            }
        }
    }
}