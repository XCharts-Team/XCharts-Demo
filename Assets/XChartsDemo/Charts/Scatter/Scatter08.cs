using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Scatter08 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public double x;
            public double y;
            public double z;
            public string name;
            public string country;
        }

        ScatterChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<ScatterChart>();
            PraseJson(Resources.Load<TextAsset>("scatter08").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            SetSerieSymbol(infos);
            m_Chart.ClearData();
            foreach (var info in infos)
            {
                m_Chart.AddData(0, new List<double>() { info.x, info.y, info.z }, info.name);
            }
        }

        void SetSerieSymbol(JsonInfo[] infos)
        {
            foreach (var serie in m_Chart.series)
            {
                serie.itemStyle.color = GetSerieColor(serie.serieName);
                serie.itemStyle.borderColor = GetSerieColor(serie.serieName);
                serie.itemStyle.borderWidth = 2;
                serie.itemStyle.opacity = 0.35f;
                serie.symbol.sizeType = SymbolSizeType.FromData;
                serie.symbol.dataIndex = 2;
            }
        }

        private Color GetSerieColor(string continent)
        {
            return ColorUtil.GetColor("#5B8FF9");;
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