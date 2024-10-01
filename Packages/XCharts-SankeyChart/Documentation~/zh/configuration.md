# 配置项手册

## Sankey

class in XCharts.Runtime.Sankeys / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

桑基图是一种特殊的流图（可以看作是有向无环图）。 它主要用来表示原材料、能量等如何从最初形式经过中间过程的加工或转化达到最终状态。

### Sankey.collapse

`bool` `false` `v3.11.0`

是否开启折叠。

### Sankey.collapseLevel

`int` `-1` `v3.11.0`

折叠限制的层级。层级从0开始，-1表示不限制。

### Sankey.collapseMutex

`bool` `true` `v3.11.0`

是否开启折叠互斥。

### Sankey.curveness

`float` `0.5f`

线条的弯曲程度。

### Sankey.defaultExpandDataIndex

`int` `-1` `v3.11.0`

默认展开的数据索引。

### Sankey.draggable

`bool`

是否可拖拽。

### Sankey.levelStyle

`LevelStyle`

层级样式。

### Sankey.lineGradient

`bool` `true` `v3.11.0`

是否开启线条渐变。开启后lineStyle的color将不生效。

### Sankey.nodeAlign

[Sankey.NodeAlign](#sankeynodealign)

节点对齐方式。

可选：

- `Top`: 顶部对齐
- `Center`: 居中对齐
- `Bottom`: 底部对齐

### Sankey.nodeGap

`float` `8`

节点的间距。

### Sankey.nodeWidth

`float` `20`

节点的宽度。
