# Configuration

## Gauge

class in XCharts.Runtime.Gauges / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

serie of gauge chart.

### Gauge.gaugeAnchor

[GaugeAnchor](#gaugeanchor)

仪表盘指针固定点。

### Gauge.gaugeAxis

[GaugeAxis](#gaugeaxis)

仪表盘轴线。

### Gauge.gaugePointer

[GaugePointer](#gaugepointer)

仪表盘指针。

### Gauge.loop

`bool` `false` `v3.6.0`

the value is loop.

### Gauge.rangeDataMode

`bool` `false` `v3.6.0`

Whether the value is range data. When this mode is enabled, each value in data is an array, the first value of the array is the starting value, and the second value is the ending value. The pointer has only one, and the data is drawn as a ring.

## GaugeAnchor

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

### GaugeAnchor.gap

`float` `0`

the gap of symbol and line segment.

### GaugeAnchor.image

`Sprite`

自定义的标记图形。

### GaugeAnchor.imageType

`Image.Type`

### GaugeAnchor.itemStyle

`ItemStyle`

The style of data item.

### GaugeAnchor.offsetCenter

`Vector2` `Vector2(0, 0)`

The offset position relative to the center.

### GaugeAnchor.show

`bool` `true`

Whether to display the anchor.

### GaugeAnchor.showAbove

`bool` `true`

固定点是否显示在指针上面。

### GaugeAnchor.size

`float` `6`

the size of symbol.

### GaugeAnchor.type

`SymbolType`

the type of symbol.

## GaugeAxis

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

Settings related to gauge axis line.

### GaugeAxis.axisLabel

`AxisLabel`

axis label style.

### GaugeAxis.axisLabelText

`List<string>`

Coordinate axis scale label custom content. When the content is empty, `axisLabel` automatically displays the content according to the scale; otherwise, the content is taken from the list definition.

### GaugeAxis.axisLine

[GaugeAxisLine](#gaugeaxisline)

axis line style.

### GaugeAxis.axisTick

`AxisTick`

axis tick style.

### GaugeAxis.distance

`float`

### GaugeAxis.overlap

`bool` `true`

### GaugeAxis.show

`bool` `true`

### GaugeAxis.splitLine

`AxisSplitLine`

slit line style.

### GaugeAxis.type

[GaugeAxisType](#gaugeaxistype)



Options:

- `None`: 仪表盘类型
- `Section`: 分段
- `Progress`: 进度

## GaugeAxisLine

class in XCharts.Runtime.Gauges / Inherits from: [BaseLine](https://xcharts-team.github.io/docs/configuration#baseline)

### GaugeAxisLine.backgroundColor

`Color32` `Color32(230, 235, 248, 255)`

The background color of gauge axis.

### GaugeAxisLine.stageColor

`List<StageColor>`

The colors of stage.

### GaugeAxisLine.stageGradient

`bool` `v3.4.0`

Whether to use gradients for transitions.

## GaugePointer

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

Settings related to gauge pointer.

### GaugePointer.autoColor

`bool` `true`

### GaugePointer.backExtraLength

`float` `0.05f`

Pointer back extra length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.backLength

`float` `0.05f`

Pointer back length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.bottomLeftLength

`float` `0.025f`

Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.bottomRightLength

`float` `0.025f`

Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.color

`Color32`

### GaugePointer.cornerRadius

`float[]`

The radius of rounded corner. Its unit is px. Use array to respectively specify the 4 corner radiuses((clockwise upper left, upper right, bottom right and bottom left)).

### GaugePointer.distance

`float`

### GaugePointer.length

`float` `0.6f`

Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.roundCap

`bool`

### GaugePointer.show

`bool` `true`

Whether to display a pointer.

### GaugePointer.toColor

`Color32`

### GaugePointer.topLeftLength

`float` `0f`

Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.topRightLength

`float` `0f`

Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).

### GaugePointer.value

`double` `v3.6.0`

The value of pointer. When it is a clock gauge, the value can be specified to control the position of the pointer.
