using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{
    [DisallowMultipleComponent]
    public class Line15_DynamicDataAndTimeAxis : MonoBehaviour
    {
        public int maxCache = 100;
        LineChart chart;
        System.DateTime now;
        float value;
        float m_LastTime;

        void Awake()
        {
            chart = gameObject.GetComponent<LineChart>();
            chart.SetMaxCache(maxCache);
            AddData();
        }

        void Update()
        {
            if (Time.time - m_LastTime >= 1f)
            {
                for (int i = 0; i < 5; i++)
                    RandomData();
                m_LastTime = Time.time;
            }
        }

        void AddData()
        {
            chart.ClearData();
            value = Random.Range(0, 1000);
            now = new System.DateTime(1997, 9, 3);
            for (int i = 0; i < maxCache; i++)
            {
                RandomData();
            }
        }

        void RandomData()
        {
            now = now.AddDays(1);
            value = value + Random.Range(0, 1f) * 21 - 10;
            chart.AddData(0, now, value);
        }
    }
}