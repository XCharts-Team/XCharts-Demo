# Configuration

## Force

class in XCharts.Runtime.Graphs / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The force layout of the graph.

### Force.centerDataIndex

`int` `-1`

the index of the center node data.

### Force.edgeLength

`float` `80`

the distance between the two nodes of the edge, this distance will also be affected by repulsion.

### Force.friction

`float` `0.6f`

the friction factor of the node movement, the larger the value, the slower the node movement.

### Force.iterations

`int` `200`

The number of iterations of the force layout.

### Force.show

`bool` `true`

### Force.stepCount

`int` `1`

### Force.stepFactor

`float` `1f`

The step factor of the force layout.

## Graph

class in XCharts.Runtime.Graphs / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

Graph chart component. It is used for showing the relationship between nodes.

### Graph.force

[Force](#force)

the force layout of the graph.

### Graph.levelStyle

`LevelStyle`

the style of level.
