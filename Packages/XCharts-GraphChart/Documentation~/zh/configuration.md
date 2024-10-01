# 配置项手册

## Force

class in XCharts.Runtime.Graphs / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

图表的力引导布局。

### Force.centerDataIndex

`int` `-1`

中心节点数据的索引。

### Force.edgeLength

`float` `80`

边的两个节点之间的距离，这个距离也会受 repulsion 影响。

### Force.friction

`float` `0.6f`

节点移动的摩擦因子，该值越大节点移动越慢。

### Force.iterations

`int` `200`

力引导布局的迭代次数。

### Force.show

`bool` `true`

### Force.stepCount

`int` `1`

### Force.stepFactor

`float` `1f`

力引导布局的步进因子。

## Graph

class in XCharts.Runtime.Graphs / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

关系图，用于展现节点以及节点之间的关系数据。

### Graph.force

[Force](#force)

图表的力引导布局。

### Graph.levelStyle

`LevelStyle`

层级样式。
