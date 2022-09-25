using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Radar06 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string item;
            public string user;
            public double score;
        }

        RadarChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<RadarChart>();
            PraseJson(Resources.Load<TextAsset>("radar06").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();
            var indicatorList = new List<string>();
            foreach (var info in infos)
            {
                if (!indicatorList.Contains(info.item))
                    indicatorList.Add(info.item);
            }
            var aData = new List<double>();
            var bData = new List<double>();
            foreach (var indicator in indicatorList)
            {
                foreach (var info in infos)
                {
                    if (info.item != indicator) continue;
                    if (info.user == "a")
                        aData.Add(info.score);
                    else if (info.user == "b")
                        bData.Add(info.score);
                }
            }
            var radar = m_Chart.GetOrAddChartComponent<RadarCoord>();
            radar.AddIndicatorList(indicatorList, 0, 80);
            m_Chart.AddData(0, aData, "a");
            m_Chart.AddData(0, bData, "b");
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