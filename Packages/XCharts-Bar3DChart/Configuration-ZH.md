# 配置项手册

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)

## Serie 系列

- [Bar3D](#Bar3D)

## ChildComponent 子组件

- [Bar3DStyle](#Bar3DStyle)

## `Bar3D`

Inherits or Implemented: [Serie](#Serie),[INeedSerieContainer](#INeedSerieContainer)

3D柱图。支持立方柱和圆柱。可水平排列和垂直排列。

|field|default|since|comment|
|--|--|--|--|
|`bar3DType`||v3.1.0|</br>`Bar3DType`:</br>- `Cube`: 立方柱。</br>- `Cylinder`: 圆柱。</br>|
|`bar3DStyle`||| [Bar3DStyle](#Bar3DStyle)|

## `Bar3DStyle`

Inherits or Implemented: [ChildComponent](#ChildComponent)

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`verticalArrange`|false||是否垂直排列。
|`verticalArrangeDire`|Vector3(-1, 1)||垂直排列时的方向。
|`verticalArrangeGap`|0.5f||垂直排列时两个柱子间的间隙。
|`barOffset`|Vector3.zero||柱子偏移。
|`widthRate`|0.5f||方形柱侧边宽度相对正面的比例。
|`topColorRate`|0.8f||柱子顶部相对正面的颜色比例。
|`bottomColorRate`|1f||柱子底部相对正面的颜色比例。
|`sideColorRate`|0.7f||方形柱侧边相对正面的颜色比例。
|`cubeDire`|Vector3(1, 1)||方形柱形成3D效果的方向。
|`cylinderRate`|0.5f|v3.1.0|圆柱的顶部椭圆比列。

[XCharts主页](https://github.com/XCharts-Team/XCharts)</br>
[XChartsAPI接口](XChartsAPI-ZH.md)</br>
[XCharts问答](XChartsFAQ-ZH.md)
