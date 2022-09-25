using System;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{

    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Parallel04 : MonoBehaviour
    {
        [Serializable]
        class JsonInfo
        {
            public string week;
            public string time;
            public double value;
        }

        ParallelChart m_Chart;

        void Awake()
        {
            m_Chart = GetComponent<ParallelChart>();
            var textColor = ColorUtil.GetColor("#fff");
            for (int i = 0; i < 8; i++)
            {
                var parallelAxis = m_Chart.GetChartComponent<ParallelAxis>(i);
                parallelAxis.axisName.show = true;
                parallelAxis.axisName.name = schema[i];
                parallelAxis.minMaxType = Axis.AxisMinMaxType.Default;
                parallelAxis.min = 0;
                parallelAxis.max = 0;
                parallelAxis.splitNumber = 0;
                parallelAxis.interval = 0;
                parallelAxis.axisLabel.textStyle.color = textColor;
                parallelAxis.axisName.labelStyle.textStyle.color = textColor;
                if (i == 7)
                {
                    parallelAxis.type = Axis.AxisType.Category;
                    parallelAxis.data = category;
                }
            }
            InitData(0, "Beijing", dataBJ);
            InitData(1, "Guangzhou", dataGZ);
            InitData(2, "Shanghai", dataSH);
        }

        private void InitData(int serieIndex, string serieName, List<List<object>> dataBJ)
        {
            var serie = m_Chart.GetSerie(serieIndex);
            serie.serieName = serieName;
            serie.lineStyle.width = 1;
            serie.lineStyle.opacity = 0.5f;
            foreach (var list in dataBJ)
            {
                var categoryIndex = category.IndexOf((string) list[7]);
                var data = new List<double>();
                for (int i = 0; i < 7; i++)
                {
                    var value = Convert.ToDouble(list[i]);
                    data.Add(value);
                }
                data.Add(categoryIndex);
                m_Chart.AddData(serieIndex, data);
            }
        }

        List<string> schema = new List<string> { "日期", "AQI", "PM2.5", "PM10", "CO", "NO2", "SO2", "等级" };
        List<string> category = new List<string> { "优", "良", "轻度污染", "中度污染", "重度污染", "严重污染" };

        List<List<object>> dataBJ = new List<List<object>>()
        {
            new List<object>() { 1, 55, 9, 56, 0.46, 18, 6, "良" },
            new List<object>() { 2, 25, 11, 21, 0.65, 34, 9, "优" },
            new List<object>() { 3, 56, 7, 63, 0.3, 14, 5, "良" },
            new List<object>() { 4, 33, 7, 29, 0.33, 16, 6, "优" },
            new List<object>() { 5, 42, 24, 44, 0.76, 40, 16, "优" },
            new List<object>() { 6, 82, 58, 90, 1.77, 68, 33, "良" },
            new List<object>() { 7, 74, 49, 77, 1.46, 48, 27, "良" },
            new List<object>() { 8, 78, 55, 80, 1.29, 59, 29, "良" },
            new List<object>() { 9, 267, 216, 280, 4.8, 108, 64, "重度污染" },
            new List<object>() { 10, 185, 127, 216, 2.52, 61, 27, "中度污染" },
            new List<object>() { 11, 39, 19, 38, 0.57, 31, 15, "优" },
            new List<object>() { 12, 41, 11, 40, 0.43, 21, 7, "优" },
            new List<object>() { 13, 64, 38, 74, 1.04, 46, 22, "良" },
            new List<object>() { 14, 108, 79, 120, 1.7, 75, 41, "轻度污染" },
            new List<object>() { 15, 108, 63, 116, 1.48, 44, 26, "轻度污染" },
            new List<object>() { 16, 33, 6, 29, 0.34, 13, 5, "优" },
            new List<object>() { 17, 94, 66, 110, 1.54, 62, 31, "良" },
            new List<object>() { 18, 186, 142, 192, 3.88, 93, 79, "中度污染" },
            new List<object>() { 19, 57, 31, 54, 0.96, 32, 14, "良" },
            new List<object>() { 20, 22, 8, 17, 0.48, 23, 10, "优" },
            new List<object>() { 21, 39, 15, 36, 0.61, 29, 13, "优" },
            new List<object>() { 22, 94, 69, 114, 2.08, 73, 39, "良" },
            new List<object>() { 23, 99, 73, 110, 2.43, 76, 48, "良" },
            new List<object>() { 24, 31, 12, 30, 0.5, 32, 16, "优" },
            new List<object>() { 25, 42, 27, 43, 1, 53, 22, "优" },
            new List<object>() { 26, 154, 117, 157, 3.05, 92, 58, "中度污染" },
            new List<object>() { 27, 234, 185, 230, 4.09, 123, 69, "重度污染" },
            new List<object>() { 28, 160, 120, 186, 2.77, 91, 50, "中度污染" },
            new List<object>() { 29, 134, 96, 165, 2.76, 83, 41, "轻度污染" },
            new List<object>() { 30, 52, 24, 60, 1.03, 50, 21, "良" },
            new List<object>() { 31, 46, 5, 49, 0.28, 10, 6, "优" }
        };
        List<List<object>> dataGZ = new List<List<object>>
        {
            new List<object>() { 1, 26, 37, 27, 1.163, 27, 13, "优" },
            new List<object>() { 2, 85, 62, 71, 1.195, 60, 8, "良" },
            new List<object>() { 3, 78, 38, 74, 1.363, 37, 7, "良" },
            new List<object>() { 4, 21, 21, 36, 0.634, 40, 9, "优" },
            new List<object>() { 5, 41, 42, 46, 0.915, 81, 13, "优" },
            new List<object>() { 6, 56, 52, 69, 1.067, 92, 16, "良" },
            new List<object>() { 7, 64, 30, 28, 0.924, 51, 2, "良" },
            new List<object>() { 8, 55, 48, 74, 1.236, 75, 26, "良" },
            new List<object>() { 9, 76, 85, 113, 1.237, 114, 27, "良" },
            new List<object>() { 10, 91, 81, 104, 1.041, 56, 40, "良" },
            new List<object>() { 11, 84, 39, 60, 0.964, 25, 11, "良" },
            new List<object>() { 12, 64, 51, 101, 0.862, 58, 23, "良" },
            new List<object>() { 13, 70, 69, 120, 1.198, 65, 36, "良" },
            new List<object>() { 14, 77, 105, 178, 2.549, 64, 16, "良" },
            new List<object>() { 15, 109, 68, 87, 0.996, 74, 29, "轻度污染" },
            new List<object>() { 16, 73, 68, 97, 0.905, 51, 34, "良" },
            new List<object>() { 17, 54, 27, 47, 0.592, 53, 12, "良" },
            new List<object>() { 18, 51, 61, 97, 0.811, 65, 19, "良" },
            new List<object>() { 19, 91, 71, 121, 1.374, 43, 18, "良" },
            new List<object>() { 20, 73, 102, 182, 2.787, 44, 19, "良" },
            new List<object>() { 21, 73, 50, 76, 0.717, 31, 20, "良" },
            new List<object>() { 22, 84, 94, 140, 2.238, 68, 18, "良" },
            new List<object>() { 23, 93, 77, 104, 1.165, 53, 7, "良" },
            new List<object>() { 24, 99, 130, 227, 3.97, 55, 15, "良" },
            new List<object>() { 25, 146, 84, 139, 1.094, 40, 17, "轻度污染" },
            new List<object>() { 26, 113, 108, 137, 1.481, 48, 15, "轻度污染" },
            new List<object>() { 27, 81, 48, 62, 1.619, 26, 3, "良" },
            new List<object>() { 28, 56, 48, 68, 1.336, 37, 9, "良" },
            new List<object>() { 29, 82, 92, 174, 3.29, 0, 13, "良" },
            new List<object>() { 30, 106, 116, 188, 3.628, 101, 16, "轻度污染" },
            new List<object>() { 31, 118, 50, 0, 1.383, 76, 11, "轻度污染" }
        };
        List<List<object>> dataSH = new List<List<object>>
        {
            new List<object>() { 1, 91, 45, 125, 0.82, 34, 23, "良" },
            new List<object>() { 2, 65, 27, 78, 0.86, 45, 29, "良" },
            new List<object>() { 3, 83, 60, 84, 1.09, 73, 27, "良" },
            new List<object>() { 4, 109, 81, 121, 1.28, 68, 51, "轻度污染" },
            new List<object>() { 5, 106, 77, 114, 1.07, 55, 51, "轻度污染" },
            new List<object>() { 6, 109, 81, 121, 1.28, 68, 51, "轻度污染" },
            new List<object>() { 7, 106, 77, 114, 1.07, 55, 51, "轻度污染" },
            new List<object>() { 8, 89, 65, 78, 0.86, 51, 26, "良" },
            new List<object>() { 9, 53, 33, 47, 0.64, 50, 17, "良" },
            new List<object>() { 10, 80, 55, 80, 1.01, 75, 24, "良" },
            new List<object>() { 11, 117, 81, 124, 1.03, 45, 24, "轻度污染" },
            new List<object>() { 12, 99, 71, 142, 1.1, 62, 42, "良" },
            new List<object>() { 13, 95, 69, 130, 1.28, 74, 50, "良" },
            new List<object>() { 14, 116, 87, 131, 1.47, 84, 40, "轻度污染" },
            new List<object>() { 15, 108, 80, 121, 1.3, 85, 37, "轻度污染" },
            new List<object>() { 16, 134, 83, 167, 1.16, 57, 43, "轻度污染" },
            new List<object>() { 17, 79, 43, 107, 1.05, 59, 37, "良" },
            new List<object>() { 18, 71, 46, 89, 0.86, 64, 25, "良" },
            new List<object>() { 19, 97, 71, 113, 1.17, 88, 31, "良" },
            new List<object>() { 20, 84, 57, 91, 0.85, 55, 31, "良" },
            new List<object>() { 21, 87, 63, 101, 0.9, 56, 41, "良" },
            new List<object>() { 22, 104, 77, 119, 1.09, 73, 48, "轻度污染" },
            new List<object>() { 23, 87, 62, 100, 1, 72, 28, "良" },
            new List<object>() { 24, 168, 128, 172, 1.49, 97, 56, "中度污染" },
            new List<object>() { 25, 65, 45, 51, 0.74, 39, 17, "良" },
            new List<object>() { 26, 39, 24, 38, 0.61, 47, 17, "优" },
            new List<object>() { 27, 39, 24, 39, 0.59, 50, 19, "优" },
            new List<object>() { 28, 93, 68, 96, 1.05, 79, 29, "良" },
            new List<object>() { 29, 188, 143, 197, 1.66, 99, 51, "中度污染" },
            new List<object>() { 30, 174, 131, 174, 1.55, 108, 50, "中度污染" },
            new List<object>() { 31, 187, 143, 201, 1.39, 89, 53, "中度污染" }
        };
    }
}