using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Polar08 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string week;
            public string time;
            public double value;
        }

        PolarChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<PolarChart>();
            PraseJson(Resources.Load<TextAsset>("polar08").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();

            var angleData = new List<string>();
            var radiusData = new List<string>();
            foreach (var info in infos)
            {
                if (!angleData.Contains(info.time))
                    angleData.Add(info.time);
                if (!radiusData.Contains(info.week))
                    radiusData.Add(info.week);
            }
            var xAxis = m_Chart.GetOrAddChartComponent<AngleAxis>();
            xAxis.data = angleData;
            var yAxis = m_Chart.GetOrAddChartComponent<RadiusAxis>();
            yAxis.data = radiusData;

            var visualMap = m_Chart.GetOrAddChartComponent<VisualMap>();
            var colors = new List<string> { "#BAE7FF", "#1890FF", "#1028ff" };
            visualMap.AddColors(colors);
            visualMap.autoMinMax = true;

            foreach (var info in infos)
            {
                var xValue = (double) radiusData.IndexOf(info.week);
                var yValue = (double) angleData.IndexOf(info.time);
                m_Chart.AddData(0, new List<double>() { xValue, yValue, info.value });
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