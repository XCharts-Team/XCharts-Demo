
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    //[ExecuteInEditMode]
    public class Simplified00_SimplifiedLineChart : MonoBehaviour
    {
        [SerializeField] 
        private int maxCache = 19000;
        private BaseChart chart;
        private float lastTime = 0;
        private int count = 0;
        private Dictionary<int, double> lastValues = new Dictionary<int, double>();
        void Awake()
        {
            chart = GetComponent<BaseChart>();
            chart.SetMaxCache(maxCache);
            InitData();
        }

        private void Update()
        {
            if (count >= maxCache)
            {
                if (Time.time - lastTime >= 0.2f)
                {
                    lastTime = Time.time;
                    AddOneData(count++);
                }
            }
            else
            {
                for (int i = 0; i < 50; i++)
                {
                    AddOneData(count++);
                }
            }
        }

        void InitData()
        {
            var serie = chart.GetSerie(0);
            serie.symbol.show = false;
            for (int i = 0; i < maxCache; i++)
            {
                AddOneData(count++);
            }
        }

        void AddOneData(int i = -1)
        {
            for (var j = 0; j < chart.series.Count; j++)
            {
                if (!lastValues.ContainsKey(j))
                {
                    lastValues[j] = 0;
                }
                if (i >= 0 && i < 100)
                    lastValues[j] += UnityEngine.Random.Range(0, 5);
                else
                    lastValues[j] += UnityEngine.Random.Range(-4, 5);
                chart.AddData(j, lastValues[j]);
            }
            chart.AddXAxisData(i.ToString());
        }
    }
}
