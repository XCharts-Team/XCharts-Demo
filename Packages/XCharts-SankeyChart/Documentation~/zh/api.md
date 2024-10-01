# API

## Sankey

class in XCharts.Runtime.Sankeys / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)

桑基图是一种特殊的流图（可以看作是有向无环图）。 它主要用来表示原材料、能量等如何从最初形式经过中间过程的加工或转化达到最终状态。

### Sankey.defaultColorBy

public override SerieColorBy defaultColorBy  

### Sankey.levelStyle

public LevelStyle levelStyle  
层级样式。

### Sankey.AddDefaultSerie

public static void AddDefaultSerie(BaseChart chart, string serieName)  

### Sankey.GetLevelItemStyle

public ItemStyle GetLevelItemStyle(int depth)  

### Sankey.GetLevelLabel

public LabelStyle GetLevelLabel(int depth)  

### Sankey.GetLevelLineStyle

public LineStyle GetLevelLineStyle(int depth)  

## Sankey.NodeAlign

class in XCharts.Runtime.Sankeys

节点对齐方式。

可选：

- `Top`: 顶部对齐
- `Center`: 居中对齐
- `Bottom`: 底部对齐

## SankeyChart

class in XCharts.Runtime.Sankeys / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

