# 配置项手册

## Force

> class in XCharts.Runtime.Graphs / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

图表的力引导布局。

```mdx-code-block
<APITable name="Force">
```

|参数|默认|版本|描述|
|--|--|--|--|
|show|true||
|stepFactor|1f||力引导布局的步进因子。
|stepCount|1||
|friction|0.6f||节点移动的摩擦因子，该值越大节点移动越慢。
|edgeLength|80||边的两个节点之间的距离，这个距离也会受 repulsion 影响。
|centerDataIndex|-1||中心节点数据的索引。
|iterations|200||力引导布局的迭代次数。

```mdx-code-block
</APITable>
```

## Graph

> class in XCharts.Runtime.Graphs / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

关系图，用于展现节点以及节点之间的关系数据。

```mdx-code-block
<APITable name="Graph">
```

|参数|默认|版本|描述|
|--|--|--|--|
|levelStyle|||层级样式。
|force|||图表的力引导布局。 [Force](#force)|

```mdx-code-block
</APITable>
```

