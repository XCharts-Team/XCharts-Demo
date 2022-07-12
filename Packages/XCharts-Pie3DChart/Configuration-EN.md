# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Pie3D](#Pie3D)

## ChildComponent

- [Pie3DStyle](#Pie3DStyle)

## `Pie3D`

Inherits or Implemented: [Serie](#Serie)

|field|default|since|comment|
|--|--|--|--|
|`pie3DStyle`||| [Pie3DStyle](#Pie3DStyle)|

## `Pie3DStyle`

Inherits or Implemented: [ChildComponent](#ChildComponent)

Pie 3d style.

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`ellipseMinorAxis`|0.65f||The minor axis length of ellipse.
|`pieMaxHeight`|20f||The max height of 3d pie.
|`pieAutoHeight`|false||Whether auto set 3d pie height by data rate.
|`selectedOffset`|Vector2(0.1f, 0.5f)||The offset of selected pie slice. 被选中状态的饼图块的额外偏移。
|`peripherySideColorRate`|0.8f||The periphery side color rate of 3d pie.
|`startSideColorRate`|0.7f||The start side color rate of 3d pie.
|`endSideColorRate`|0.65f||The end side color rate of 3d pie.

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
