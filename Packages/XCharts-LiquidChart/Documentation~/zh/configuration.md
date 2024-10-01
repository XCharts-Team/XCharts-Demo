# 配置项手册

## Liquid

class in XCharts.Runtime.Liquids / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

### Liquid.waveHeight

`float` `10f`

波高。

### Liquid.waveLength

`float` `20f`

波长。为0-1小数时指直线的百分比。

### Liquid.waveOffset

`float` `0f`

波偏移。

### Liquid.waveSpeed

`float` `5f`

波速。正数时左移，负数时右移。

## Vessel

class in XCharts.Runtime.Liquids / 继承自: [MainComponent](https://xcharts-team.github.io/docs/configuration#maincomponent), [ISerieContainer](https://xcharts-team.github.io/docs/configuration#iseriecontainer), [IUpdateRuntimeData](https://xcharts-team.github.io/docs/configuration#iupdateruntimedata)

容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

### Vessel.autoColor

`bool` `true`

是否自动颜色。为true时颜色会和serie一致。 [default: true]

### Vessel.backgroundColor

`Color32`

背景色，默认透明。 [default: `Color.clear`]

### Vessel.borderColor

`Color32` `Color32(70, 70, 240, 255)`

容器内壁边框颜色。默认和serie一致。

### Vessel.borderWidth

`float` `0f`

内壁边框。

### Vessel.center

`float[]`

When value between 0 and 1 represents a percentage  relative to the chart.

### Vessel.color

`Color32` `Color32(70, 70, 240, 255)`

容器颜色。默认和serie一致。

### Vessel.cornerRadius

`float[]`

容器的圆角半径。用数组分别指定4个圆角半径（顺时针左上，右上，右下，左下）。shape为Rect时有效。

### Vessel.gap

`float` `5f`

间隙。容器和液体的间隙。 [defaut: 10f]

### Vessel.height

`float` `0.7f`

When value between 0 and 1 represents a percentage relative to the chart.

### Vessel.radius

`float` `0.35f`

When value between 0 and 1 represents a percentage relative to the chart.

### Vessel.shape

[Vessel.Shape](#vesselshape)

容器形状。 [default: Shape.Circle]

可选：

- `Circle`: 圆形
- `Rect`: 正方形。
- `Triangle`: 三角形。
- `Diamond`: 菱形。

### Vessel.shapeWidth

`float` `5f`

容器厚度。 [defaut: 5f]

### Vessel.show

`bool` `true`

是否显示容器组件。 [defaut: true]

### Vessel.smoothness

`float` `1f`

水波平滑度。 [default: 1f]

### Vessel.width

`float` `0.5f`

When value between 0 and 1 represents a percentage relative to the chart.
