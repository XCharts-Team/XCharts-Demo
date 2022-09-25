using System;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Scatter05 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string gender;
            public double height;
            public double weight;
        }

        ScatterChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<ScatterChart>();
            PraseJson(Resources.Load<TextAsset>("scatter05").text);
        }

        private void PraseJson(string json)
        {
            var infos = JsonHelper.GetJsonArray<JsonInfo>(json);
            m_Chart.ClearData();
            foreach (var info in infos)
            {
                var serieIndex = info.gender == "male" ? 1 : 0;
                m_Chart.AddData(serieIndex, info.height, info.weight);
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