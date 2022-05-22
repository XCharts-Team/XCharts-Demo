using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Bar18_AnimationDelay : MonoBehaviour
    {
        void Awake()
        {
            var chart = GetComponent<BaseChart>();
            if (chart == null) return;
            chart.ClearData();
            for (int i = 0; i <= 100; i++)
            {
                var theta = (i / 100f) * 360;
                chart.AddXAxisData("A" + i);
                chart.AddData(0, (System.Math.Sin(i / 5d) * (i / 5d - 10) + i / 6d) * 5d);
                chart.AddData(1, (System.Math.Cos(i / 5d) * (i / 5d - 10) + i / 6d) * 5d);
            }

            chart.GetSerie(0).animation.fadeInDelayFunction = delegate(int dataIndex)
            {
                return dataIndex * 10f;
            };
            chart.GetSerie(1).animation.fadeInDelayFunction = delegate(int dataIndex)
            {
                return dataIndex * 10 + 100f;
            };
        }
    }
}