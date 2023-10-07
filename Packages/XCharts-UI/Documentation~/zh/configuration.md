# 配置项手册

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
|animationStyle|||起始动画。

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
|supportScroll|true||是否支持滚动。
|supportDrag|false||是否支持拖拽。
|supportSelect|false||是否支持选中。选中行，列，单元格。
|rowHeight|0f||行高。
|rowGap|0f||行间距。
|columnWidth|0f||列宽。默认0，自适应。Columns中设置有时优先用Columns中的值，没有时用这个值。
|borderWidth|0f||边框宽度。
|borderColor|||边框颜色。
|minColumnWidth|100f||最小列宽。
|minRowHeight|30f||最小行高。
|scrollSensitivity|10f||滚动灵敏度。
|selectColor|||选中时的颜色。
|selectHeaderColor|||选中时表头的颜色。
|rowBackgroundColors|||行背景颜色列表。
|separatorStyle|||分割线样式。 [TableSeparatorStyle](#tableseparatorstyle)|
|scrollbarStyle|||滚动条样式。 [TableScrollbarStyle](#tablescrollbarstyle)|
|columnHeaderStyle|||默认的列头样式。 [TableColumnHeaderStyle](#tablecolumnheaderstyle)|
|rowHeaderStyle|||行表头样式。 [TableRowHeaderStyle](#tablerowheaderstyle)|
|columns|||列表头样式。
|data|||表格数据。

```mdx-code-block
</APITable>
```

## UITimePicker

> XCharts.Runtime.UI.UITimePicker : [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

