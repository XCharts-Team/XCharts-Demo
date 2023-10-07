# 配置项手册

## Pie3D

> XCharts.Runtime.Pie3Ds.Pie3D : [Serie](https://xcharts-team.github.io/docs/configuration#serie)

```mdx-code-block
<APITable name="Pie3D">
```


|field|default|since|comment|
|--|--|--|--|
|pie3DStyle||| [Pie3DStyle](#pie3dstyle)|

```mdx-code-block
</APITable>
```

## Pie3DStyle

> XCharts.Runtime.Pie3Ds.Pie3DStyle : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

3D饼图样式。

```mdx-code-block
<APITable name="Pie3DStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||
|ellipseMinorAxis|0.65f||椭圆的短轴长度。当为0-1的浮点数时为长轴的百分比。
|pieMaxHeight|20f||饼图厚度。
|pieAutoHeight|false||是否自动根据比例计算厚度。
|selectedOffset|Vector2(0.1f, 0.5f)||The offset of selected pie slice. 被选中状态的饼图块的额外偏移。
|peripherySideColorRate|0.8f||饼图切块的侧面颜色。
|startSideColorRate|0.7f||饼图切块的起始面颜色（顺时针）。
|endSideColorRate|0.65f||饼图切块的结束面颜色（顺时针）。

```mdx-code-block
</APITable>
```

