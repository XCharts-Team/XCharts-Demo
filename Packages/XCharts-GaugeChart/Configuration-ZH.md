# 配置项手册

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)

## Serie 系列

- [Gauge](#Gauge)

## ChildComponent 子组件

- [GaugeAnchor](#GaugeAnchor)
- [GaugeAxis](#GaugeAxis)
- [GaugePointer](#GaugePointer)

## Other 其他

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
|`show`|true||是否显示指针固定点。
|`showAbove`|true||固定点是否显示在指针上面。
|`type`|||标记类型。
|`size`|6||标记的大小。
|`gap`|0||图形标记和线条的间隙距离。
|`image`|||自定义的标记图形。
|`imageType`|||
|`offsetCenter`|Vector2(0, 0)||相对于中心的偏移位置。
|`itemStyle`|||图形样式。

## `GaugeAxis`

Inherits or Implemented: [ChildComponent](#ChildComponent)

仪表盘轴线相关设置。

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`type`|||</br>`GaugeAxisType`:</br>- `None`: 仪表盘类型</br>- `Section`: 分段</br>- `Progress`: 进度</br>|
|`overlap`|true||
|`distance`|||
|`axisLine`|||仪表盘轴线样式。 [GaugeAxisLine](#GaugeAxisLine)|
|`splitLine`|||分割线。
|`axisTick`|||刻度。
|`axisLabel`|||文本标签。
|`axisLabelText`|||自定义Label的内容。

## `GaugeAxisLine`

Inherits or Implemented: [BaseLine](#BaseLine)

|field|default|since|comment|
|--|--|--|--|
|`backgroundColor`|Color32(230, 235, 248, 255)||进度条背景颜色。
|`stageColor`|||阶段颜色。

## `GaugePointer`

Inherits or Implemented: [ChildComponent](#ChildComponent)

仪表盘指针相关设置。

|field|default|since|comment|
|--|--|--|--|
|`show`|true||是否显示指针。
|`length`|0.6f||指针长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`backLength`|0.05f||指针后凸出的长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`backExtraLength`|0.05f||指针后额外的长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`topLeftLength`|0f||指针顶部左边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`topRightLength`|0f||指针顶部右边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`bottomLeftLength`|0.025f||指针底部左边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`bottomRightLength`|0.025f||指针底部右边凸起长度。可以是绝对值，也可以是相对于半径的百分比（0-1的浮点数）。
|`distance`|||
|`roundCap`|||
|`autoColor`|true||
|`color`|||
|`toColor`|||
|`cornerRadius`|||圆角半径。用数组分别指定4个圆角半径（顺时针左上，右上，右下，左下）。

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)
