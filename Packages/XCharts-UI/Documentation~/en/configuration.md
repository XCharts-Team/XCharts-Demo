# Configuration

## ITableCell

> XCharts.Runtime.UI.ITableCell / Subclasses: [TableCell](#tablecell)

## TableCell

> XCharts.Runtime.UI.TableCell : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent), [ITableCell](#itablecell)

表格的单元格数据。

```mdx-code-block
<APITable name="TableCell">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示当前数据。
|type|||<br/>`DataType`:<br/>- `Custom`: <br/>- `String`: <br/>- `Double`: <br/>- `Bool`: <br/>- `Sprite`: <br/>|
|value|||
|sprite|||图片数据。当type为Sprite时有效。

```mdx-code-block
</APITable>
```

## TableColumn

> XCharts.Runtime.UI.TableColumn : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头内容和样式。

```mdx-code-block
<APITable name="TableColumn">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示列表头。
|content|||列表头内容。
|width|0f||列宽。默认为0时列宽平分。
|dataLabelStyle|||当前列的数据文本样式。默认不启用，而是共用TableColumnHeaderStyle的defaultDataLabelStyle。
|headerLabelStyle|||当前列的列表头文本样式。默认不启用，而是共用TableColumnHeaderStyle的defalutHeaderLabelStyle。

```mdx-code-block
</APITable>
```

## TableColumnHeaderStyle

> XCharts.Runtime.UI.TableColumnHeaderStyle : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头样式。

```mdx-code-block
<APITable name="TableColumnHeaderStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示列表头。
|height|50f||列表头高度。
|backgroundColor|||列表头背景色。
|background|||背景图片样式。
|defaultHeaderLabelStyle|||
|defaultDataLabelStyle|||默认的列数据文本样式。

```mdx-code-block
</APITable>
```

## TableRow

> XCharts.Runtime.UI.TableRow : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格的行数据。

```mdx-code-block
<APITable name="TableRow">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示当前行。
|name|||行名称。可用于显示在行表头，用通配符{name}。
|height|||当前行的自定义高度。默认为0不自定义。
|data|||行数据列表。

```mdx-code-block
</APITable>
```

## TableRowHeaderStyle

> XCharts.Runtime.UI.TableRowHeaderStyle : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

行表头样式。

```mdx-code-block
<APITable name="TableRowHeaderStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示行表头。
|width|100f||宽度。
|backgroundColor|||背景色。
|labelStyle|||文本样式。

```mdx-code-block
</APITable>
```

## TableScrollbarStyle

> XCharts.Runtime.UI.TableScrollbarStyle : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格滚动条样式。

```mdx-code-block
<APITable name="TableScrollbarStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|false||是否显示滚动条。
|horizontal|false||是否显示水平滚动条。
|vertical|true||是否显示垂直滚动条。
|width|5||滚动条宽度。
|backgroundColor|||滚动条背景色。
|color|||滚动条颜色。

```mdx-code-block
</APITable>
```

## TableSeparatorStyle

> XCharts.Runtime.UI.TableSeparatorStyle : [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格分割线样式。

```mdx-code-block
<APITable name="TableSeparatorStyle">
```


|field|default|since|comment|
|--|--|--|--|
|show|true||是否显示分割线。
|vertical|true||是否显示垂直分割线。
|verticalColumn|true||是否显示列表头的垂直分割线。
|horizontal|true||是否显示水平分割线。
|horizontalColumn|true||是否显示列表头的水平分割线。
|width|1f||分割线宽度。
|color|Color.clear||分割线颜色。

```mdx-code-block
</APITable>
```

## UIStatistic

> XCharts.Runtime.UI.UIStatistic : [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

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

> XCharts.Runtime.UI.UITable : [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

表格UI组件。 用于展示行列数据。

```mdx-code-block
<APITable name="UITable">
```


|field|default|since|comment|
|--|--|--|--|
|supportScroll|true||whether the table support scroll.
|supportDrag|false||whether the table support drag.
|supportSelect|false||whether the table support select. select row, column, cell.
|rowHeight|0f||the height of row.
|rowGap|0f||the gap of row.
|columnWidth|0f||the width of column. default 0, auto width. if set, it will be used first.
|borderWidth|0f||the width of border.
|borderColor|||the color of border.
|minColumnWidth|100f||the min width of column.
|minRowHeight|30f||the min height of row.
|scrollSensitivity|10f||the scroll sensitivity.
|selectColor|||the color of selected row, column, cell.
|selectHeaderColor|||the color of selected header.
|rowBackgroundColors|||the background color of row.
|separatorStyle|||the style of separator. [TableSeparatorStyle](#tableseparatorstyle)|
|scrollbarStyle|||the style of scrollbar. [TableScrollbarStyle](#tablescrollbarstyle)|
|columnHeaderStyle|||the default style of column header. [TableColumnHeaderStyle](#tablecolumnheaderstyle)|
|rowHeaderStyle|||the style of row header. [TableRowHeaderStyle](#tablerowheaderstyle)|
|columns|||the style of column header.
|data|||the data of table.

```mdx-code-block
</APITable>
```

## UITimePicker

> XCharts.Runtime.UI.UITimePicker : [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

