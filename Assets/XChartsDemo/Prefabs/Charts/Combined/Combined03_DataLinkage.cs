
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Combined03_DataLinkage : MonoBehaviour
    {
        void Awake()
        {
            var chart = GetComponent<BaseChart>();
            if (chart == null) return;
            chart.onAxisPointerValueChanged = delegate (Axis axis, double value)
            {
                if (axis is XAxis)
                {
                    var dataIndex = (int)value;
                    var data0 = chart.GetData(0, dataIndex);
                    var data1 = chart.GetData(1, dataIndex);
                    var data2 = chart.GetData(2, dataIndex);
                    var data3 = chart.GetData(3, dataIndex);
                    chart.UpdateData(4, 0, data0);
                    chart.UpdateData(4, 1, data1);
                    chart.UpdateData(4, 2, data2);
                    chart.UpdateData(4, 3, data3);
                }
            };
        }
    }
}
