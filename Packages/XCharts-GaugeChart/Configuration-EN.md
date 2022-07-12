# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Gauge](#Gauge)

## ChildComponent

- [GaugeAnchor](#GaugeAnchor)
- [GaugeAxis](#GaugeAxis)
- [GaugePointer](#GaugePointer)

## Other

- [GaugeAxisLine](#GaugeAxisLine)

## `Gauge`

Inherits or Implemented: [Serie](#Serie)

|field|default|since|comment|
|--|--|--|--|
|`gaugeAxis`|||仪表盘轴线。 [GaugeAxis](#GaugeAxis)|
|`gaugePointer`|||仪表盘指针。 [GaugePointer](#GaugePointer)|
|`gaugeAnchor`|||仪表盘指针固定点。 [GaugeAnchor](#GaugeAnchor)|

## `GaugeAnchor`

Inherits or Implemented: [ChildComponent](#ChildComponent)

|field|default|since|comment|
|--|--|--|--|
|`show`|true||Whether to display the anchor.
|`showAbove`|true||固定点是否显示在指针上面。
|`type`|||the type of symbol.
|`size`|6||the size of symbol.
|`gap`|0||the gap of symbol and line segment.
|`image`|||自定义的标记图形。
|`imageType`|||
|`offsetCenter`|Vector2(0, 0)||The offset position relative to the center.
|`itemStyle`|||The style of data item.

## `GaugeAxis`

Inherits or Implemented: [ChildComponent](#ChildComponent)

Settings related to gauge axis line.

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`type`|||</br>`GaugeAxisType`:</br>- `None`: 仪表盘类型</br>- `Section`: 分段</br>- `Progress`: 进度</br>|
|`overlap`|true||
|`distance`|||
|`axisLine`|||axis line style. [GaugeAxisLine](#GaugeAxisLine)|
|`splitLine`|||slit line style.
|`axisTick`|||axis tick style.
|`axisLabel`|||axis label style.
|`axisLabelText`|||Coordinate axis scale label custom content. When the content is empty, `axisLabel` automatically displays the content according to the scale; otherwise, the content is taken from the list definition.

## `GaugeAxisLine`

Inherits or Implemented: [BaseLine](#BaseLine)

|field|default|since|comment|
|--|--|--|--|
|`backgroundColor`|Color32(230, 235, 248, 255)||进度条背景颜色。
|`stageColor`|||阶段颜色。

## `GaugePointer`

Inherits or Implemented: [ChildComponent](#ChildComponent)

Settings related to gauge pointer.

|field|default|since|comment|
|--|--|--|--|
|`show`|true||Whether to display a pointer.
|`length`|0.6f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`backLength`|0.05f||Pointer back length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`backExtraLength`|0.05f||Pointer back extra length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`topLeftLength`|0f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`topRightLength`|0f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`bottomLeftLength`|0.025f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`bottomRightLength`|0.025f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|`distance`|||
|`roundCap`|||
|`autoColor`|true||
|`color`|||
|`toColor`|||
|`cornerRadius`|||The radius of rounded corner. Its unit is px. Use array to respectively specify the 4 corner radiuses((clockwise upper left, upper right, bottom right and bottom left)).

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
