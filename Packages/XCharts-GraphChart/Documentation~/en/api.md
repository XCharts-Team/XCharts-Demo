# API

## Force

> class in XCharts.Runtime.Graphs / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

The force layout of the graph.

## Graph

> class in XCharts.Runtime.Graphs / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

Graph chart component. It is used for showing the relationship between nodes.

|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static void AddDefaultSerie(BaseChart chart, string serieName)|
|AddLink()||public override SerieDataLink AddLink(string sourceId, string targetId, double value = 0)|
|AddSerieData()||public override void AddSerieData(SerieData serieData)|
|ClearData()||public override void ClearData()<br/>清空所有数据 |
|GetLevelItemStyle()||public ItemStyle GetLevelItemStyle(int depth)|
|GetLevelLabel()||public LabelStyle GetLevelLabel(int depth)|
|GetLevelLineStyle()||public LineStyle GetLevelLineStyle(int depth)|

## GraphChart

> class in XCharts.Runtime.Graphs / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)


