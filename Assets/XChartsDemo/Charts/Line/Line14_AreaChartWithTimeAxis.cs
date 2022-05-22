using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{
    //[ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Line14_AreaChartWithTimeAxis : MonoBehaviour
    {
        BaseChart m_Chart;
        float m_LastTime;

        void Awake()
        {
            m_Chart = GetComponent<BaseChart>();
            var xAxis = m_Chart.GetChartComponent<XAxis>();
            xAxis.type = Axis.AxisType.Time;
            xAxis.boundaryGap = false;
            AddData();
        }

        void AddData()
        {
            m_Chart.ClearData();
            var baseDate = new System.DateTime(1998, 9, 3);

            var lastValue = Random.Range(0, 1f) * 300f;
            m_Chart.AddData(0, baseDate, lastValue);
            for (int i = 1; i < 500; i++)
            {
                baseDate = baseDate.AddDays(1);
                lastValue = Mathf.Round((Random.Range(0, 1f) - 0.5f) * 20f + lastValue);
                m_Chart.AddData(0, baseDate, lastValue);
            }
        }
    }
}