# 配置项手册

## Bar3D

> class in XCharts.Runtime.Bar3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

3D柱图。支持立方柱和圆柱。可水平排列和垂直排列。

```mdx-code-block
<APITable name="Bar3D">
```

|参数|默认|版本|描述|
|--|--|--|--|
|bar3DType||v3.1.0|<br/>`Bar3DType`:<br/>- `Cube`: 立方柱。<br/>- `Cylinder`: 圆柱。<br/>|
|bar3DStyle||| [Bar3DStyle](#bar3dstyle)|

```mdx-code-block
</APITable>
```

## Bar3DStyle

> class in XCharts.Runtime.Bar3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

```mdx-code-block
<APITable name="Bar3DStyle">
```

|参数|默认|版本|描述|
|--|--|--|--|
|show|true||
|verticalArrange|false||是否垂直排列。
|verticalArrangeDire|Vector3(-1, 1)||垂直排列时的方向。
|verticalArrangeGap|0.5f||垂直排列时两个柱子间的间隙。
|barOffset|Vector3.zero||柱子偏移。
|widthRate|0.5f||方形柱侧边宽度相对正面的比例。
|topColorRate|0.8f||柱子顶部相对正面的颜色比例。
|bottomColorRate|1f||柱子底部相对正面的颜色比例。
|sideColorRate|0.7f||方形柱侧边相对正面的颜色比例。
|cubeDire|Vector3(1, 1)||方形柱形成3D效果的方向。
|cylinderRate|0.5f|v3.1.0|圆柱的顶部椭圆比列。
|topColor||v3.6.0|
|bottomColor||v3.6.0|
|sideColor||v3.6.0|

```mdx-code-block
</APITable>
```

