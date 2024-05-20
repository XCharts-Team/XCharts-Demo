# Configuration

## Force

> class in XCharts.Runtime.Graphs / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The force layout of the graph.

```mdx-code-block
<APITable name="Force">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||
|stepFactor|1f||The step factor of the force layout.
|stepCount|1||
|friction|0.6f||the friction factor of the node movement, the larger the value, the slower the node movement.
|edgeLength|80||the distance between the two nodes of the edge, this distance will also be affected by repulsion.
|centerDataIndex|-1||the index of the center node data.
|iterations|200||The number of iterations of the force layout.

```mdx-code-block
</APITable>
```

## Graph

> class in XCharts.Runtime.Graphs / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

Graph chart component. It is used for showing the relationship between nodes.

```mdx-code-block
<APITable name="Graph">
```


|field|default|since|comment|
|--|--|--|--|
|levelStyle|||the style of level.
|force|||the force layout of the graph. [Force](#force)|

```mdx-code-block
</APITable>
```

