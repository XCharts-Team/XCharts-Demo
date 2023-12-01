# Configuration

## Gauge

> class in XCharts.Runtime.Gauges / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

```mdx-code-block
<APITable name="Gauge">
```


|field|default|since|comment|
|--|--|--|--|
|rangeDataMode|false|v3.6.0|Whether the value is range data. When this mode is enabled, each value in data is an array, the first value of the array is the starting value, and the second value is the ending value. The pointer has only one, and the data is drawn as a ring.
|loop|false|v3.6.0|the value is loop.
|gaugeAxis|||仪表盘轴线。 [GaugeAxis](#gaugeaxis)|
|gaugePointer|||仪表盘指针。 [GaugePointer](#gaugepointer)|
|gaugeAnchor|||仪表盘指针固定点。 [GaugeAnchor](#gaugeanchor)|

```mdx-code-block
</APITable>
```

## GaugeAnchor

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

```mdx-code-block
<APITable name="GaugeAnchor">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||Whether to display the anchor.
|showAbove|true||固定点是否显示在指针上面。
|type|||the type of symbol.
|size|6||the size of symbol.
|gap|0||the gap of symbol and line segment.
|image|||自定义的标记图形。
|imageType|||
|offsetCenter|Vector2(0, 0)||The offset position relative to the center.
|itemStyle|||The style of data item.

```mdx-code-block
</APITable>
```

## GaugeAxis

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

Settings related to gauge axis line.

```mdx-code-block
<APITable name="GaugeAxis">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||
|type|||<br/>`GaugeAxisType`:<br/>- `None`: 仪表盘类型<br/>- `Section`: 分段<br/>- `Progress`: 进度<br/>|
|overlap|true||
|distance|||
|axisLine|||axis line style. [GaugeAxisLine](#gaugeaxisline)|
|splitLine|||slit line style.
|axisTick|||axis tick style.
|axisLabel|||axis label style.
|axisLabelText|||Coordinate axis scale label custom content. When the content is empty, `axisLabel` automatically displays the content according to the scale; otherwise, the content is taken from the list definition.

```mdx-code-block
</APITable>
```

## GaugeAxisLine

> class in XCharts.Runtime.Gauges / Inherits from: [BaseLine](https://xcharts-team.github.io/docs/configuration#baseline)

```mdx-code-block
<APITable name="GaugeAxisLine">
```


|field|default|since|comment|
|--|--|--|--|
|backgroundColor|Color32(230, 235, 248, 255)||The background color of gauge axis.
|stageColor|||The colors of stage.
|stageGradient||v3.4.0|Whether to use gradients for transitions.

```mdx-code-block
</APITable>
```

## GaugePointer

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

Settings related to gauge pointer.

```mdx-code-block
<APITable name="GaugePointer">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||Whether to display a pointer.
|length|0.6f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|backLength|0.05f||Pointer back length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|backExtraLength|0.05f||Pointer back extra length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|topLeftLength|0f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|topRightLength|0f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|bottomLeftLength|0.025f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|bottomRightLength|0.025f||Pointer length. It can be an absolute value, or it can be a percentage relative to the radius (0-1).
|distance|||
|roundCap|||
|autoColor|true||
|color|||
|toColor|||
|cornerRadius|||The radius of rounded corner. Its unit is px. Use array to respectively specify the 4 corner radiuses((clockwise upper left, upper right, bottom right and bottom left)).
|value||v3.6.0|The value of pointer. When it is a clock gauge, the value can be specified to control the position of the pointer.

```mdx-code-block
</APITable>
```

