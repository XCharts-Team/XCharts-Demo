
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Line24_TwoValueAxesInPolar : MonoBehaviour
    {
        void Awake()
        {
            var chart = GetComponent<BaseChart>();
            if (chart == null) return;
            chart.ClearData();
            for (int i = 0; i <= 100; i++)
            {
                var theta = (i / 100f) * 360;
                var r = 5 * (1 + Mathf.Sin((theta / 180) * Mathf.PI));
                chart.AddData(0, r, theta);
            }
        }
    }
}
