using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Line16_FunctionPolt : MonoBehaviour
    {
        void Awake()
        {
            var chart = gameObject.GetComponent<LineChart>();
            chart.ClearData();
            for (float i = -200; i <= 200; i += 0.1f)
            {
                chart.AddData(0, i, func(i));
            }
        }

        double func(float x)
        {
            x /= 10f;
            return Mathf.Sin(x) * Mathf.Cos(x * 2 + 1) * Mathf.Sin(x * 3 + 2) * 50;
        }
    }
}