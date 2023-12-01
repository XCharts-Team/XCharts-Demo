# Configuration

## Bar3D

> class in XCharts.Runtime.Bar3Ds / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

Bar3D.

```mdx-code-block
<APITable name="Bar3D">
```


|field|default|since|comment|
|--|--|--|--|
|bar3DType||v3.1.0|<br/>`Bar3DType`:<br/>- `Cube`: Cube.<br/>- `Cylinder`: Cylinder.<br/>|
|bar3DStyle||| [Bar3DStyle](#bar3dstyle)|

```mdx-code-block
</APITable>
```

## Bar3DStyle

> class in XCharts.Runtime.Bar3Ds / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

```mdx-code-block
<APITable name="Bar3DStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||
|verticalArrange|false||Vertical arrange or not.
|verticalArrangeDire|Vector3(-1, 1)||The direction vector of vertical.
|verticalArrangeGap|0.5f||The gap of vertical arrange bar3d.
|barOffset|Vector3.zero||The offset of bar.
|widthRate|0.5f||The rate of side width.
|topColorRate|0.8f||The color rate of top.
|bottomColorRate|1f||The color rate of bottom.
|sideColorRate|0.7f||The color rate of side.
|cubeDire|Vector3(1, 1)||The direction vector of bar3d.
|cylinderRate|0.5f|v3.1.0|The rate of top ellipse.
|topColor||v3.6.0|
|bottomColor||v3.6.0|
|sideColor||v3.6.0|

```mdx-code-block
</APITable>
```

