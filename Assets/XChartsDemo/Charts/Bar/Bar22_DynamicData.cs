using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Bar22_DynamicData : MonoBehaviour
    {
        private BarChart chart;
        private float lastTime;
        private System.DateTime now;
        private int count;

        void Awake()
        {
            chart = gameObject.GetComponent<BarChart>();
            chart.ClearData();
            chart.SetMaxCache(10);
            now = new System.DateTime(2022, 1, 1);
            for (int i = 0; i < 10; i++)
                AddData();
        }

        void Update()
        {
            if (Time.time - lastTime >= 2f)
            {
                lastTime = Time.time;
                AddData();
            }
        }

        void AddData()
        {
            now = now.AddSeconds(2);
            chart.AddXAxisData(now.ToString("HH:mm:ss"), 0);
            chart.AddXAxisData(count.ToString(), 1);
            chart.AddData(0, Random.Range(0, 1000));
            chart.AddData(1, Random.Range(0, 10) + 5);
            count++;
        }
    }
}