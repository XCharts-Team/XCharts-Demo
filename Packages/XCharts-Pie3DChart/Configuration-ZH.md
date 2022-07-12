# 配置项手册

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)

## Serie 系列

- [Pie3D](#Pie3D)

## ChildComponent 子组件

- [Pie3DStyle](#Pie3DStyle)

## `Pie3D`

Inherits or Implemented: [Serie](#Serie)

|field|default|since|comment|
|--|--|--|--|
|`pie3DStyle`||| [Pie3DStyle](#Pie3DStyle)|

## `Pie3DStyle`

Inherits or Implemented: [ChildComponent](#ChildComponent)

3D饼图样式。

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`ellipseMinorAxis`|0.65f||椭圆的短轴长度。当为0-1的浮点数时为长轴的百分比。
|`pieMaxHeight`|20f||饼图厚度。
|`pieAutoHeight`|false||是否自动根据比例计算厚度。
|`selectedOffset`|Vector2(0.1f, 0.5f)||The offset of selected pie slice. 被选中状态的饼图块的额外偏移。
|`peripherySideColorRate`|0.8f||饼图切块的侧面颜色。
|`startSideColorRate`|0.7f||饼图切块的起始面颜色（顺时针）。
|`endSideColorRate`|0.65f||饼图切块的结束面颜色（顺时针）。

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)
