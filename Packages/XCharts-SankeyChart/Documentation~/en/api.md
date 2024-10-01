# API

## Sankey

class in XCharts.Runtime.Sankeys / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

Sankey diagram is a special flow diagram, which is mainly used to express how the raw materials, energy and so on flow from the initial form to the final state through the intermediate process.

### Sankey.defaultColorBy

public override SerieColorBy defaultColorBy  

### Sankey.levelStyle

public LevelStyle levelStyle  
the style of level.

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

the align of node.

Options:

- `Top`: top align.
- `Center`: center align.
- `Bottom`: bottom align.

## SankeyChart

class in XCharts.Runtime.Sankeys / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

