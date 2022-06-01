using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using XCharts.Runtime;

namespace XCharts.Demo
{
    [Serializable]
    class CountryInfo
    {
        public double income;
        public double lineExperctancy;
        public long population;
        public string country;
        public int year;
    }

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Line17_LineRace : MonoBehaviour
    {
        LineChart m_Chart;
        float m_LastTime;

        void Awake()
        {
            m_Chart = GetComponent<LineChart>();
            LoadDataFromFile(Resources.Load<TextAsset>("Line17_life-expectancy-table").text);
        }

        void Update()
        {
            if (Time.time - m_LastTime >= 12f)
            {
                m_LastTime = Time.time;
                m_Chart.AnimationReset();
                m_Chart.AnimationFadeIn();
            }
        }

        private void LoadDataFromFile(string json)
        {
            m_Chart.ClearData();
            json = json.Substring(1, json.Length - 2);
            var temp = json.Split(']');
            CountryInfo info = new CountryInfo();
            var countries = new List<string>()
            {
                "Finland",
                "France",
                "Germany",
                "Iceland",
                "Norway",
                "Poland",
                "Russia",
                "United Kingdom"
            };
            for (int i = 1950; i <= 2015; i++)
            {
                m_Chart.AddXAxisData(i.ToString());
            }
            for (int i = 0; i < countries.Count; i++)
            {
                var serie = m_Chart.GetSerie(i);
                serie.serieName = countries[i];
                serie.symbol.show = false;
                serie.animation.fadeInDelay = 0;
                serie.animation.fadeInDuration = 10000;
                serie.AddExtraComponent<EndLabelStyle>();
            }
            for (int i = 1; i < temp.Length; i++)
            {
                if (string.IsNullOrEmpty(temp[i])) continue;
                var temp2 = temp[i].Substring(2);
                var temp3 = temp2.Split(',');
                info.income = double.Parse(temp3[0]);
                info.lineExperctancy = double.Parse(temp3[1]);
                info.population = long.Parse(temp3[2]);
                info.country = temp3[3].Substring(1, temp3[3].Length - 2);
                info.year = int.Parse(temp3[4]);

                if (info.year >= 1950)
                {
                    var index = countries.IndexOf(info.country);
                    if (index < 0) continue;
                    m_Chart.AddData(index, info.income);
                }
            }
        }
    }
}