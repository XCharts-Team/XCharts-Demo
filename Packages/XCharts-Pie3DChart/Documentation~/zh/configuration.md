# 配置项手册

## Pie3D

class in XCharts.Runtime.Pie3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

3D饼图系列。

### Pie3D.pie3DStyle

[Pie3DStyle](#pie3dstyle)

## Pie3DStyle

class in XCharts.Runtime.Pie3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

3D饼图样式。

### Pie3DStyle.drawSplitSide

`bool` `true` `v3.10.0`

是否绘制分割面。当pieAutoHeight为true时，该值无效。

### Pie3DStyle.ellipseMinorAxis

`float` `0.65f`

椭圆的短轴长度。当为0-1的浮点数时为长轴的百分比。

### Pie3DStyle.endSideColorRate

`float` `0.65f`

饼图切块的结束面颜色（顺时针）。

### Pie3DStyle.peripherySideColorRate

`float` `0.8f`

饼图切块的侧面颜色。

### Pie3DStyle.pieAutoHeight

`bool` `false`

是否自动根据比例计算厚度。

### Pie3DStyle.pieMaxHeight

`float` `20f`

饼图厚度。

### Pie3DStyle.selectedOffset

`Vector2` `Vector2(0.1f, 0.5f)`

被选中状态的饼图块的额外偏移。

### Pie3DStyle.show

`bool` `true`

### Pie3DStyle.startSideColorRate

`float` `0.7f`

饼图切块的起始面颜色（顺时针）。
