using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Scatter07 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string continent;
            public string Country;
            public double LifeExpectancy;
            public double GDP;
            public double Population;
        }

        ScatterChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<ScatterChart>();
            PraseJson(Resources.Load<TextAsset>("scatter07").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            SetSerieSymbol(infos);
            m_Chart.ClearData();
            foreach (var info in infos)
            {
                var serieIndex = GetSerieIndex(info.continent);
                m_Chart.AddData(serieIndex, new List<double>() { info.GDP, info.LifeExpectancy, info.Population }, info.Country);
            }
        }

        void SetSerieSymbol(JsonInfo[] infos)
        {
            var minPopulation = double.MaxValue;
            var maxPopulation = 0d;
            foreach (var info in infos)
            {
                if (info.Population > maxPopulation) maxPopulation = info.Population;
                if (info.Population < minPopulation) minPopulation = info.Population;
            }
            double scale = 100.0 / maxPopulation;
            foreach (var serie in m_Chart.series)
            {
                serie.itemStyle.color = GetSerieColor(serie.serieName);
                serie.itemStyle.borderColor = GetSerieColor(serie.serieName);
                serie.itemStyle.borderWidth = 2;
                serie.itemStyle.opacity = 0.35f;
                serie.symbol.sizeType = SymbolSizeType.Function;
                serie.symbol.sizeFunction = delegate(List<double> data)
                {
                    float size = (float) (data[2] * scale);
                    if (size < 8) size = 8;
                    return size;
                };
            }
        }

        private int GetSerieIndex(string continent)
        {
            switch (continent)
            {
                case "Americas":
                    return 0;
                case "Asia":
                    return 1;
                case "Europe":
                    return 2;
                case "Oceania":
                    return 3;
            }
            return -1;
        }

        private Color GetSerieColor(string continent)
        {
            switch (continent)
            {
                case "Americas":
                    return ColorUtil.GetColor("#2FC25B");
                case "Asia":
                    return ColorUtil.GetColor("#1890FF");;
                case "Europe":
                    return ColorUtil.GetColor("#FACC14");;
                case "Oceania":
                    return ColorUtil.GetColor("#223273");;
            }
            return ColorUtil.GetColor("#2FC25B");;
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