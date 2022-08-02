# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Bar3D](#Bar3D)

## ChildComponent

- [Bar3DStyle](#Bar3DStyle)

## `Bar3D`

Inherits or Implemented: [Serie](#Serie),[INeedSerieContainer](#INeedSerieContainer)

Bar3D.

|field|default|since|comment|
|--|--|--|--|
|`bar3DType`||v3.1.0|</br>`Bar3DType`:</br>- `Cube`: Cube.</br>- `Cylinder`: Cylinder.</br>|
|`bar3DStyle`||| [Bar3DStyle](#Bar3DStyle)|

## `Bar3DStyle`

Inherits or Implemented: [ChildComponent](#ChildComponent)

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`verticalArrange`|false||Vertical arrange or not.
|`verticalArrangeDire`|Vector3(-1, 1)||The direction vector of vertical.
|`verticalArrangeGap`|0.5f||The gap of vertical arrange bar3d.
|`barOffset`|Vector3.zero||The offset of bar.
|`widthRate`|0.5f||The rate of side width.
|`topColorRate`|0.8f||The color rate of top.
|`bottomColorRate`|1f||The color rate of bottom.
|`sideColorRate`|0.7f||The color rate of side.
|`cubeDire`|Vector3(1, 1)||The direction vector of bar3d.
|`cylinderRate`|0.5f|v3.1.0|The rate of top ellipse.

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
