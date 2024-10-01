# Configuration

## Sankey

class in XCharts.Runtime.Sankeys / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

Sankey diagram is a special flow diagram, which is mainly used to express how the raw materials, energy and so on flow from the initial form to the final state through the intermediate process.

### Sankey.collapse

`bool` `false` `v3.11.0`

whether collapse.

### Sankey.collapseLevel

`int` `-1` `v3.11.0`

the level of collapse. The level starts from 0, and -1 means no limit.

### Sankey.collapseMutex

`bool` `true` `v3.11.0`

whether collapse mutex.

### Sankey.curveness

`float` `0.5f`

the curveness of line.

### Sankey.defaultExpandDataIndex

`int` `-1` `v3.11.0`

the default expand data index.

### Sankey.draggable

`bool`

whether draggable.

### Sankey.levelStyle

`LevelStyle`

the style of level.

### Sankey.lineGradient

`bool` `true` `v3.11.0`

whether line gradient. If enabled, the color of lineStyle will not work.

### Sankey.nodeAlign

[Sankey.NodeAlign](#sankeynodealign)

the align of node.

Options:

- `Top`: top align.
- `Center`: center align.
- `Bottom`: bottom align.

### Sankey.nodeGap

`float` `8`

the gap of node.

### Sankey.nodeWidth

`float` `20`

the width of node.
