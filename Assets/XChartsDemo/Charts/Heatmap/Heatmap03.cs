using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Heatmap03 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string Date;
            public string District;
            public double AQHI;
        }

        HeatmapChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<HeatmapChart>();
            PraseJson(Resources.Load<TextAsset>("heatmap03").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();

            var xData = new List<string>();
            var yData = new List<string>();
            var min = double.MaxValue;
            var max = double.MinValue;
            foreach (var info in infos)
            {
                if (!yData.Contains(info.District))
                    yData.Add(info.District);
                if (!xData.Contains(info.Date))
                    xData.Add(info.Date);
                if (info.AQHI < min) min = info.AQHI;
                if (info.AQHI > max) max = info.AQHI;
            }
            xData.Sort();
            var xAxis = m_Chart.GetOrAddChartComponent<XAxis>();
            xAxis.data = xData;
            var yAxis = m_Chart.GetOrAddChartComponent<YAxis>();
            yAxis.data = yData;

            var visualMap = m_Chart.GetOrAddChartComponent<VisualMap>();
            var colors = new List<string>
            {
                "#174c83",
                "#7eb6d4",
                "#efefeb",
                "#efa759",
                "#9b4d16"
            };
            visualMap.AddColors(colors);
            visualMap.min = min;
            visualMap.max = (double) Mathf.FloorToInt((float)max);

            foreach (var info in infos)
            {
                var xValue = (double) xData.IndexOf(info.Date);
                var yValue = (double) yData.IndexOf(info.District);
                m_Chart.AddData(0, new List<double>() { xValue, yValue, info.AQHI });
            }
        }

        public class JsonHelper
        {
            public static T[] GetJsonArray<T>(string json)
            {
                string newJson = "{ \"array\": " + json + "}";
                Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
                return wrapper.array;
            }

            [Serializable]
            private class Wrapper<T>
            {
#pragma warning disable 0649
                public T[] array;
#pragma warning restore 0649
            }
        }
    }
}