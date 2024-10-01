# 配置项手册

## Gauge

class in XCharts.Runtime.Gauges / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

仪表盘系列数据。

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

数值是否循环。可用在钟表图。

### Gauge.rangeDataMode

`bool` `false` `v3.6.0`

数值是否为范围数据。启用该模式后，data中的每个值都是一个数组，数组中的第一个值为起始值，第二个值为结束值。指针只有一个，数据绘制为环形。

## GaugeAnchor

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

### GaugeAnchor.gap

`float` `0`

图形标记和线条的间隙距离。

### GaugeAnchor.image

`Sprite`

自定义的标记图形。

### GaugeAnchor.imageType

`Image.Type`

### GaugeAnchor.itemStyle

`ItemStyle`

图形样式。

### GaugeAnchor.offsetCenter

`Vector2` `Vector2(0, 0)`

相对于中心的偏移位置。

### GaugeAnchor.show

`bool` `true`

是否显示指针固定点。

### GaugeAnchor.showAbove

`bool` `true`

固定点是否显示在指针上面。

### GaugeAnchor.size

`float` `6`

标记的大小。

### GaugeAnchor.type

`SymbolType`

标记类型。

## GaugeAxis

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

仪表盘轴线相关设置。

### GaugeAxis.axisLabel

`AxisLabel`

文本标签。

### GaugeAxis.axisLabelText

`List<string>`

自定义Label的内容。

### GaugeAxis.axisLine

[GaugeAxisLine](#gaugeaxisline)

仪表盘轴线样式。

### GaugeAxis.axisTick

`AxisTick`

刻度。

### GaugeAxis.distance

`float`

### GaugeAxis.overlap

`bool` `true`

### GaugeAxis.show

`bool` `true`

### GaugeAxis.splitLine

`AxisSplitLine`

分割线。

### GaugeAxis.type

[GaugeAxisType](#gaugeaxistype)



可选：

- `None`: 仪表盘类型
- `Section`: 分段
- `Progress`: 进度

## GaugeAxisLine

class in XCharts.Runtime.Gauges / 继承自: [BaseLine](https://xcharts-team.github.io/docs/configuration#baseline)

### GaugeAxisLine.backgroundColor

`Color32` `Color32(230, 235, 248, 255)`

进度条背景颜色。

### GaugeAxisLine.stageColor

`List<StageColor>`

阶段颜色。

### GaugeAxisLine.stageGradient

`bool` `v3.4.0`

阶段颜色是否渐变过渡。

## GaugePointer

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

仪表盘指针相关设置。

### GaugePointer.autoColor

`bool` `true`

### GaugePointer.backExtraLength

`float` `0.05f`

指针后额外的长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.backLength

`float` `0.05f`

指针后凸出的长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.bottomLeftLength

`float` `0.025f`

指针底部左边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.bottomRightLength

`float` `0.025f`

指针底部右边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.color

`Color32`

### GaugePointer.cornerRadius

`float[]`

圆角半径。用数组分别指定4个圆角半径（顺时针左上，右上，右下，左下）。

### GaugePointer.distance

`float`

### GaugePointer.length

`float` `0.6f`

指针长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.roundCap

`bool`

### GaugePointer.show

`bool` `true`

是否显示指针。

### GaugePointer.toColor

`Color32`

### GaugePointer.topLeftLength

`float` `0f`

指针顶部左边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.topRightLength

`float` `0f`

指针顶部右边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。

### GaugePointer.value

`double` `v3.6.0`

指针的值。当为时钟仪表盘时，可通过指定value值来控制指针的位置。
