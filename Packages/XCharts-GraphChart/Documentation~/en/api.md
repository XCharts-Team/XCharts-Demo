# API

## Force

class in XCharts.Runtime.Graphs / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

The force layout of the graph.

### Force.currentIterations

public int currentIterations  

## Graph

class in XCharts.Runtime.Graphs / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

Graph chart component. It is used for showing the relationship between nodes.

### Graph.force

public Force force  
the force layout of the graph.

### Graph.graphData

public GraphData graphData  

### Graph.levelStyle

public LevelStyle levelStyle  
the style of level.

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

class in XCharts.Runtime.Graphs / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

