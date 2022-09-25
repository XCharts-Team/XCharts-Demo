using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Candlestick04 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string time;
            public double start;
            public double max;
            public double min;
            public double end;
            public double volumn;
            public double money;
        }

        CandlestickChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<CandlestickChart>();
            var legend = m_Chart.GetOrAddChartComponent<Legend>();
            legend.AddData("上涨");
            legend.AddData("下跌");
            legend.colors.Clear();
            legend.colors.Add(m_Chart.theme.serie.candlestickColor);
            legend.colors.Add(m_Chart.theme.serie.candlestickColor0);
            PraseJson(Resources.Load<TextAsset>("candlestick04").text);

        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();
            var count = 0;
            for (int i = infos.Length - 1; i >= 0; i--)
            {
                var info = infos[i];
                var dataName = info.end >= info.start ? "上涨" : "下跌";
                m_Chart.AddXAxisData(info.time, 0);
                m_Chart.AddXAxisData(info.time, 1);
                m_Chart.AddData(0, count++, info.start, info.end, info.min, info.max, dataName);
                var serieData = m_Chart.AddData(1, info.volumn, dataName);
                var itemStyle = serieData.GetOrAddComponent<ItemStyle>();
                itemStyle.color = info.end >= info.start ?
                    m_Chart.theme.serie.candlestickColor :
                    m_Chart.theme.serie.candlestickColor0;
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