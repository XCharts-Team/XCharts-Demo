using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Heatmap06 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public double x;
            public double y;
        }

        HeatmapChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<HeatmapChart>();
            PraseJson(Resources.Load<TextAsset>("heatmap06").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();

            var visualMap = m_Chart.GetOrAddChartComponent<VisualMap>();
            var colors = new List<string>
            {
                "#BAE7FF",
                "#1890FF",
                "#0050B3"
            };
            visualMap.AddColors(colors);
            visualMap.autoMinMax = true;

            var dict = new Dictionary<int, int>();
            var xAxis = m_Chart.GetChartComponent<XAxis>();
            xAxis.type = Axis.AxisType.Value;
            // xAxis.min = 0;
            // xAxis.max = 4;
            xAxis.splitNumber = 4;
            xAxis.minorTick.show = true;
            xAxis.minorTick.splitNumber = 8;

            var yAxis = m_Chart.GetChartComponent<YAxis>();
            yAxis.type = Axis.AxisType.Value;
            // yAxis.min = 0;
            // yAxis.max = 20000;
            yAxis.splitNumber = 4;
            yAxis.minorTick.show = true;
            yAxis.minorTick.splitNumber = 8;

            foreach (var info in infos)
            {
                m_Chart.AddData(0, info.x, info.y);
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