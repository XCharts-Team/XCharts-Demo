# API

## Force

class in XCharts.Runtime.Graphs / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

图表的力引导布局。

### Force.currentIterations

public int currentIterations  

## Graph

class in XCharts.Runtime.Graphs / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)

关系图，用于展现节点以及节点之间的关系数据。

### Graph.force

public Force force  
图表的力引导布局。

### Graph.graphData

public GraphData graphData  

### Graph.levelStyle

public LevelStyle levelStyle  
层级样式。

### Graph.AddDefaultSerie

public static void AddDefaultSerie(BaseChart chart, string serieName)  

### Graph.AddLink

public override SerieDataLink AddLink(string sourceId, string targetId, double value = 0)  

### Graph.AddSerieData

public override void AddSerieData(SerieData serieData)  

### Graph.ClearData

public override void ClearData()  
清空所有数据

### Graph.GetLevelItemStyle

public ItemStyle GetLevelItemStyle(int depth)  

### Graph.GetLevelLabel

public LabelStyle GetLevelLabel(int depth)  

### Graph.GetLevelLineStyle

public LineStyle GetLevelLineStyle(int depth)  

## GraphChart

class in XCharts.Runtime.Graphs / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

