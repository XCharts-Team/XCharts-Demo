using System;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Candlestick03 : MonoBehaviour
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
            PraseJson(Resources.Load<TextAsset>("candlestick03").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();
            var count = 0;
            foreach (var info in infos)
            {
                m_Chart.AddXAxisData(info.time);
                m_Chart.AddData(0, count++, info.start, info.end, info.min, info.max);
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