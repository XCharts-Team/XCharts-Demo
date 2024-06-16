# Configuration

## Sankey

> class in XCharts.Runtime.Sankeys / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

Sankey diagram is a special flow diagram, which is mainly used to express how the raw materials, energy and so on flow from the initial form to the final state through the intermediate process.

```mdx-code-block
<APITable name="Sankey">
```


|field|default|since|comment|
|--|--|--|--|
|nodeAlign|||the align of node.<br/>`Sankey.NodeAlign`:<br/>- `Top`: top align.<br/>- `Center`: center align.<br/>- `Bottom`: bottom align.<br/>|
|nodeWidth|20||the width of node.
|nodeGap|8||the gap of node.
|draggable|||whether draggable.
|curveness|0.5f||the curveness of line.
|collapse|false|v3.11.0|whether collapse.
|collapseMutex|true|v3.11.0|whether collapse mutex.
|collapseLevel|-1|v3.11.0|the level of collapse. The level starts from 0, and -1 means no limit.
|defaultExpandDataIndex|-1|v3.11.0|the default expand data index.
|lineGradient|true|v3.11.0|whether line gradient. If enabled, the color of lineStyle will not work.
|levelStyle|||the style of level.

```mdx-code-block
</APITable>
```

