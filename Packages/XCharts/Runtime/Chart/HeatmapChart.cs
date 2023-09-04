using System.Collections.Generic;
using UnityEngine;

namespace XCharts.Runtime
{
    [AddComponentMenu("XCharts/HeatmapChart", 18)]
    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    [DisallowMultipleComponent]
    [HelpURL("https://xcharts-team.github.io/docs/configuration")]
    public class HeatmapChart : BaseChart
    {
        protected override void DefaultChart()
        {
            var grid = EnsureChartComponent<GridCoord>();
            grid.left = 0.12f;

            var xAxis = EnsureChartComponent<XAxis>();
            xAxis.type = Axis.AxisType.Category;
            xAxis.boundaryGap = true;
            xAxis.splitNumber = 10;

            var yAxis = EnsureChartComponent<YAxis>();
            yAxis.type = Axis.AxisType.Category;
            yAxis.boundaryGap = true;
            yAxis.splitNumber = 10;
            RemoveData();

            var heatmapGridWid = 10f;
            int xSplitNumber = (int) (grid.context.width / heatmapGridWid);
            int ySplitNumber = (int) (grid.context.height / heatmapGridWid);

            Heatmap.AddDefaultSerie(this, GenerateDefaultSerieName());

            var visualMap = EnsureChartComponent<VisualMap>();
            visualMap.autoMinMax = true;
            visualMap.orient = Orient.Vertical;
            visualMap.calculable = true;
            visualMap.location.align = Location.Align.BottomLeft;
            visualMap.location.bottom = 100;
            visualMap.location.left = 30;
            var colors = new List<string>
            {
                "#313695",
                "#4575b4",
                "#74add1",
                "#abd9e9",
                "#e0f3f8",
                "#ffffbf",
                "#fee090",
                "#fdae61",
                "#f46d43",
                "#d73027",
                "#a50026"
            };
            visualMap.AddColors(colors);
            for (int i = 0; i < xSplitNumber; i++)
            {
                xAxis.data.Add((i + 1).ToString());
            }
            for (int i = 0; i < ySplitNumber; i++)
            {
                yAxis.data.Add((i + 1).ToString());
            }
            for (int i = 0; i < xSplitNumber; i++)
            {
                for (int j = 0; j < ySplitNumber; j++)
                {
                    var value = Random.Range(0, 150);
                    var list = new List<double> { i, j, value };
                    AddData(0, list);
                }
            }
        }
    }
}