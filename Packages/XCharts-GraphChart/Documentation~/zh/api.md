# API

## Force

> class in XCharts.Runtime.Graphs / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

图表的力引导布局。

## Graph

> class in XCharts.Runtime.Graphs / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)

关系图，用于展现节点以及节点之间的关系数据。

|API|版本|描述|
|--|--|--|
|AddDefaultSerie()||public static void AddDefaultSerie(BaseChart chart, string serieName)|
|AddLink()||public override SerieDataLink AddLink(string sourceId, string targetId, double value = 0)|
|AddSerieData()||public override void AddSerieData(SerieData serieData)|
|ClearData()||public override void ClearData()<br/>清空所有数据 |
|GetLevelItemStyle()||public ItemStyle GetLevelItemStyle(int depth)|
|GetLevelLabel()||public LabelStyle GetLevelLabel(int depth)|
|GetLevelLineStyle()||public LineStyle GetLevelLineStyle(int depth)|

## GraphChart

> class in XCharts.Runtime.Graphs / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)


