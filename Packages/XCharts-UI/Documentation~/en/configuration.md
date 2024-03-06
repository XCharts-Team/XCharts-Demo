# Configuration

## ITableCell

> class in XCharts.Runtime.UI / Subclasses: [TableCell](#tablecell)

## TableCarouselStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The table carousel style.

```mdx-code-block
<APITable name="TableCarouselStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||
|type|||The carousel type.<br/>`TableCarouselType`:<br/>- `Pixel`: pixel carousel.<br/>- `Row`: single row carousel.<br/>- `Page`: page carousel.<br/>|
|mode|||The play mode of carousel.<br/>`TableCarouselMode`:<br/>- `Loop`: play loop.<br/>|
|waitTime|2000||wait time of carousel (ms).
|speed|100||The carousel speed.
|pause|false||pause carousel.
|hoverPause|true||Whether to pause when hover.

```mdx-code-block
</APITable>
```

## TableCell

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent), [ITableCell](#itablecell)

表格的单元格数据。

```mdx-code-block
<APITable name="TableCell">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the cell is visible.
|type|||the type of the cell data.<br/>`DataType`:<br/>- `GameObject`: <br/>- `String`: <br/>- `Double`: <br/>- `Bool`: <br/>- `Sprite`: <br/>|
|stringValue|||the string data. when type is String.
|doubleValue|||the double data. when type is Double.
|boolValue|||the bool data. when type is Bool.
|gameObjectValue|||the gameobject data. when type is GameObject.
|spriteValue|||the sprite data. when type is Sprite.

```mdx-code-block
</APITable>
```

## TableColumn

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头内容和样式。

```mdx-code-block
<APITable name="TableColumn">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the column is visible.
|content|||the content of the column header.
|width|0f||the width of the column. when width is 0, the width is average.
|dataLabelStyle|||the style of the column header. default not enabled, but use the defaultHeaderLabelStyle of TableColumnHeaderStyle.
|headerLabelStyle|||the style of the column header. default not enabled, but use the defaultHeaderLabelStyle of TableColumnHeaderStyle.

```mdx-code-block
</APITable>
```

## TableColumnHeaderStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table column header.

```mdx-code-block
<APITable name="TableColumnHeaderStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the column header is visible.
|height|50f||the height of the column header.
|backgroundColor|||the background color of the column header.
|opaque|true|v3.10.0|whether the column header is opaque.
|background|||the background style of the column header.
|defaultLabelStyle|||
|borderStyle||v3.10.0|the border style of the column header.

```mdx-code-block
</APITable>
```

## TableColumnStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The style of table column.

```mdx-code-block
<APITable name="TableColumnStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the column is visible.
|columnWidth|0f||the width of column. default 0, auto width. if set, it will be used first.
|minColumnWidth|100f||the min width of column.
|defaultLabelStyle|||the default style of the column label.
|columnBackgroundColors|||the background color of column.

```mdx-code-block
</APITable>
```

## TableRow

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the row data of the table.

```mdx-code-block
<APITable name="TableRow">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the row is visible.
|name|||the name of the row. can be used to display in the row header, use wildcard {name}.
|height|||the height of the row. default 0, auto height.
|data|||the data list of the row.

```mdx-code-block
</APITable>
```

## TableRowHeaderStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table row header.

```mdx-code-block
<APITable name="TableRowHeaderStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the row header is visible.
|width|100f||the width of the row header.
|backgroundColor|||the background color of the row header.
|labelStyle|||the style of the row header label.

```mdx-code-block
</APITable>
```

## TableRowStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The style of table row.

```mdx-code-block
<APITable name="TableRowStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether the row is visible.
|rowHeight|0f||the height of row.
|rowGap|0f||the gap of row.
|minRowHeight|30f||the min height of row.
|borderStyle||v3.10.0|the border style of row.
|rowBackgroundColors|||the background color of row.

```mdx-code-block
</APITable>
```

## TableScrollbarStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table carousel.

```mdx-code-block
<APITable name="TableScrollbarStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|false||whether the scrollbar is enable.
|horizontal|false||whether to show the horizontal scrollbar.
|vertical|true||whether to show the vertical scrollbar.
|width|10||the width of the scrollbar.
|backgroundColor|||the background color of the scrollbar.
|color|||the color of the scrollbar.
|borderStyle||v3.10.0|the border style of the scrollbar.

```mdx-code-block
</APITable>
```

## TableSeparatorStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table separator.

```mdx-code-block
<APITable name="TableSeparatorStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||whether to show the separator.
|vertical|true||whether to show the vertical separator.
|verticalColumn|true||whether to show the vertical separator of the header.
|verticalWidth|1f||the width of vertical separator.
|verticalColor|Color.clear||the color of vertical separator.
|horizontal|true||whether to show the horizontal separator.
|horizontalColumn|true||whether to show the horizontal separator of the header.
|horizontalWidth|1f||the width of horizontal separator.
|horizontalColor|Color.clear||the color of horizontal separator.

```mdx-code-block
</APITable>
```

## UIImage

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

ui component of image. 图片UI组件。

## UIStatistic

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

```mdx-code-block
<APITable name="UIStatistic">
```


|field|default|since|comment|
|--|--|--|--|
|valueLabelStyle|||
|animationStyle|||The start animation.

```mdx-code-block
</APITable>
```

## UITable

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

表格UI组件。 用于展示行列数据。

```mdx-code-block
<APITable name="UITable">
```


|field|default|since|comment|
|--|--|--|--|
|supportScroll|true||whether the table support scroll.
|supportDrag|false||whether the table support drag.
|supportSelect|true||whether the table support select. select row, column, cell.
|scrollSensitivity|10f||the scroll sensitivity.
|selectColor|||the color of selected row, column, cell.
|selectHeaderColor|||the color of selected header.
|borderStyle|||the border style of table.
|separatorStyle|||the style of separator. [TableSeparatorStyle](#tableseparatorstyle)|
|scrollbarStyle|||the style of scrollbar. [TableScrollbarStyle](#tablescrollbarstyle)|
|columnHeaderStyle|||the default style of column header. [TableColumnHeaderStyle](#tablecolumnheaderstyle)|
|columnStyle|||the column style of table. [TableColumnStyle](#tablecolumnstyle)|
|rowHeaderStyle|||the style of row header. [TableRowHeaderStyle](#tablerowheaderstyle)|
|rowStyle|||the style of row. [TableRowStyle](#tablerowstyle)|
|carouselStyle|||the style of carousel. [TableCarouselStyle](#tablecarouselstyle)|
|columns|||the style of column header.
|data|||the data of table.

```mdx-code-block
</APITable>
```

## UITimePicker

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

