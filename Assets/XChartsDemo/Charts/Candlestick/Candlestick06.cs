using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    //[ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Candlestick06 : MonoBehaviour
    {
        public int dataAmount = 10000;

        CandlestickChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<CandlestickChart>();
            GenerateOHLC(dataAmount);
        }

        private void GenerateOHLC(int count)
        {
            var xValue = new System.DateTime(2011, 1, 1);
            var minute = 60;
            double baseValue = Random.Range(0, 12000);
            var boxVals = new List<double>();
            var dayRange = 12;
            m_Chart.ClearData();
            for (int i = 0; i < count; i++)
            {
                baseValue = baseValue + Random.Range(0, 40) - 19;
                boxVals.Clear();
                for (int j = 0; j < 4; j++)
                {
                    boxVals.Add((Random.Range(0f, 1f) - 0.5f) * dayRange + baseValue);
                }
                boxVals.Sort();
                var openIdx = (int) Random.Range(0, 3);
                var closeIdx = (int) Random.Range(0, 2);
                if (closeIdx == openIdx)
                {
                    closeIdx++;
                }
                var volumn = boxVals[3] * (1000 + Random.Range(0, 500f));
                var date = xValue.ToString("yyyy-MM-dd hh:mm:ss");
                xValue = xValue.AddSeconds(minute);

                var open = boxVals[openIdx];
                var highest = boxVals[3];
                var lowest = boxVals[0];
                var close = boxVals[closeIdx];
                var trend = close >= open ? "上涨" : "下跌";
                m_Chart.AddXAxisData(date);
                m_Chart.AddData(0, i, open, close, lowest, highest, trend);
                var serieData = m_Chart.AddData(1, volumn);
                var itemStyle = serieData.GetOrAddComponent<ItemStyle>();
                itemStyle.color = close >= open ?
                    m_Chart.theme.serie.candlestickColor :
                    m_Chart.theme.serie.candlestickColor0;
            }
        }
    }
}