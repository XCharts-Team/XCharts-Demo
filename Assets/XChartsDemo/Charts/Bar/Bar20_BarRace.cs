using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XCharts.Runtime;

namespace XChartsDemo
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Bar20_BarRace : MonoBehaviour
    {
        public float updateTime = 3f;
        private BarChart chart;
        private float lastTime;

        void Awake()
        {
            chart = gameObject.GetComponent<BarChart>();
            chart.ClearData();
            nowList.Clear();
            for (int i = 0; i < 5; i++)
            {
                var value = Random.Range(0, 200);
                nowList.Add(value);
                chart.AddYAxisData("y" + i);
                chart.AddData(0, value);
            }
        }

        void Update()
        {
            if (Time.time - lastTime >= 3f)
            {
                lastTime = Time.time;
                UpdateData();
            }
        }

        List<int> nowList = new List<int>();
        void UpdateData()
        {
            var serie = chart.GetSerie(0);
            serie.animation.change.duration = updateTime * 1000;
            RandomIncrement(nowList, Random.Range(1, 200), Random.Range(10, 2000));
            for (int i = 0; i < serie.dataCount; i++)
            {
                chart.UpdateData(0, i, nowList[i]);
            }
        }

        public static void RandomIncrement(List<int> list, int baseIncrement = 1, int fastIncrement = 2)
        {
            int currentMax = list.Max();
            int fastIndex = Random.Range(0, list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                list[i] += (i == fastIndex) ? fastIncrement : baseIncrement;
            }
            if (list.All(x => x < currentMax))
            {
                list[fastIndex] = currentMax + fastIncrement;
            }
        }
    }
}