# 配置项手册

## Liquid

> class in XCharts.Runtime.Liquids / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

```mdx-code-block
<APITable name="Liquid">
```

|参数|默认|版本|描述|
|--|--|--|--|
|waveHeight|10f||波高。
|waveLength|20f||波长。为0-1小数时指直线的百分比。
|waveSpeed|5f||波速。正数时左移，负数时右移。
|waveOffset|0f||波偏移。

```mdx-code-block
</APITable>
```

## Vessel

> class in XCharts.Runtime.Liquids / 继承自: [MainComponent](https://xcharts-team.github.io/docs/configuration#maincomponent), [ISerieContainer](https://xcharts-team.github.io/docs/configuration#iseriecontainer), [IUpdateRuntimeData](https://xcharts-team.github.io/docs/configuration#iupdateruntimedata)

容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

```mdx-code-block
<APITable name="Vessel">
```

|参数|默认|版本|描述|
|--|--|--|--|
|show|true||是否显示容器组件。 [defaut: true]
|shape|||容器形状。 [default: Shape.Circle]<br/>`Vessel.Shape`:<br/>- `Circle`: 圆形<br/>- `Rect`: 正方形。<br/>- `Triangle`: 三角形。<br/>- `Diamond`: 菱形。<br/>|
|shapeWidth|5f||容器厚度。 [defaut: 5f]
|gap|5f||间隙。容器和液体的间隙。 [defaut: 10f]
|color|Color32(70, 70, 240, 255)||容器颜色。默认和serie一致。
|backgroundColor|||背景色，默认透明。 [default: `Color.clear`]
|autoColor|true||是否自动颜色。为true时颜色会和serie一致。 [default: true]
|center|||When value between 0 and 1 represents a percentage  relative to the chart.
|radius|0.35f||When value between 0 and 1 represents a percentage relative to the chart.
|smoothness|1f||水波平滑度。 [default: 1f]
|width|0.5f||When value between 0 and 1 represents a percentage relative to the chart.
|height|0.7f||When value between 0 and 1 represents a percentage relative to the chart.
|borderWidth|0f||内壁边框。
|borderColor|Color32(70, 70, 240, 255)||容器内壁边框颜色。默认和serie一致。
|cornerRadius|||容器的圆角半径。用数组分别指定4个圆角半径（顺时针左上，右上，右下，左下）。shape为Rect时有效。

```mdx-code-block
</APITable>
```

