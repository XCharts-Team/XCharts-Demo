using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Candlestick05 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public long date;
            public double[] range;
            public double start;
            public double end;
            public double lowest;
            public double highest;
            public double mean;
            public string trend;
        }

        CandlestickChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<CandlestickChart>();
            PraseJson(Resources.Load<TextAsset>("candlestick05").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();
            var legend = m_Chart.GetOrAddChartComponent<Legend>();
            legend.ClearData();
            legend.AddData("up");
            legend.AddData("down");
            legend.colors.Clear();
            legend.colors.Add(m_Chart.theme.serie.candlestickColor);
            legend.colors.Add(m_Chart.theme.serie.candlestickColor0);
            var count = 0;
            for (int i = infos.Length - 1; i >= 0; i--)
            {
                var info = infos[i];
                var date = DateTimeUtil.GetDateTime((int) (info.date / 1000)).ToString("yyyy-MM-dd");
                m_Chart.AddXAxisData(date, 0);
                m_Chart.AddData(0, info.range[0], info.trend);
                m_Chart.AddData(1, info.range[1] - info.range[0], info.trend);
                m_Chart.AddData(2, count++, info.start, info.end, info.lowest, info.highest, info.trend);
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