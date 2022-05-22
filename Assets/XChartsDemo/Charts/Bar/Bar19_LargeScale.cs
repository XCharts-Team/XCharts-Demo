using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Bar19_LargeScale : MonoBehaviour
    {
        BaseChart chart;

        void Awake()
        {
            chart = GetComponent<BaseChart>();
            if (chart == null) return;
            chart.ClearData();
            GenerateData(1000);
        }

        int baseValue, smallBaseValue;
        System.DateTime time;
        void GenerateData(int count)
        {
            baseValue = (int) (Random.Range(0, 1f) * 1000);
            time = new System.DateTime(2010, 1, 1);
            smallBaseValue = 0;
            for (int i = 0; i < count; i++)
            {
                chart.AddXAxisData(time.ToString("yyyy-MM-dd"));
                chart.AddData(0, Next(i));
                time = time.AddDays(1);
            }
        }

        int Next(int idx)
        {
            smallBaseValue = idx % 30 == 0 ?
                Random.Range(0, 700) :
                smallBaseValue + Random.Range(0, 500) - 250;
            baseValue += Random.Range(0, 20) - 10;
            return (int) Mathf.Max(0, Mathf.Round(baseValue + smallBaseValue) + 3000);
        }
    }
}