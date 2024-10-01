# 配置项手册

## Bar3D

class in XCharts.Runtime.Bar3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

3D柱图。支持立方柱和圆柱。可水平排列和垂直排列。

### Bar3D.bar3DStyle

[Bar3DStyle](#bar3dstyle)

### Bar3D.bar3DType

[Bar3DType](#bar3dtype) `v3.1.0`



可选：

- `Cube`: 立方柱。
- `Cylinder`: 圆柱。

## Bar3DStyle

class in XCharts.Runtime.Bar3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

### Bar3DStyle.barOffset

`Vector3` `Vector3.zero`

柱子偏移。

### Bar3DStyle.borderDash

`bool` `v3.10.0`

是否显示虚线边框。

### Bar3DStyle.bottomColor

`Color32` `v3.6.0`

### Bar3DStyle.bottomColorRate

`float` `1f`

柱子底部相对正面的颜色比例。

### Bar3DStyle.cubeDire

`Vector3` `Vector3(1, 1)`

方形柱形成3D效果的方向。

### Bar3DStyle.cylinderRate

`float` `0.5f` `v3.1.0`

圆柱的顶部椭圆比列。

### Bar3DStyle.occludedAreaBorder

`bool` `v3.10.0`

是否显示遮挡区域的边框。

### Bar3DStyle.occludedAreaBorderDash

`bool` `v3.10.0`

是否显示遮挡区域的虚线边框。

### Bar3DStyle.show

`bool` `true`

### Bar3DStyle.sideColor

`Color32` `v3.6.0`

### Bar3DStyle.sideColorRate

`float` `0.7f`

方形柱侧边相对正面的颜色比例。

### Bar3DStyle.topColor

`Color32` `v3.6.0`

### Bar3DStyle.topColorRate

`float` `0.8f`

柱子顶部相对正面的颜色比例。

### Bar3DStyle.verticalArrange

`bool` `false`

是否垂直排列。

### Bar3DStyle.verticalArrangeDire

`Vector3` `Vector3(-1, 1)`

垂直排列时的方向。

### Bar3DStyle.verticalArrangeGap

`float` `0.5f`

垂直排列时两个柱子间的间隙。

### Bar3DStyle.widthRate

`float` `0.5f`

方形柱侧边宽度相对正面的比例。
