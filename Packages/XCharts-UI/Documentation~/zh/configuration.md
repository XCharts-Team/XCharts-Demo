# 配置项手册

## ITableCell

class in XCharts.Runtime.UI / 子类: [TableCell](#tablecell)

## TableCarouselStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格轮播样式。

### TableCarouselStyle.hoverPause

`bool` `true`

鼠标悬停时是否暂停。

### TableCarouselStyle.mode

[TableCarouselMode](#tablecarouselmode)

轮播播放模式。

可选：

- `Loop`: 循环播放。

### TableCarouselStyle.pause

`bool` `false`

暂停轮播。

### TableCarouselStyle.show

`bool` `true`

### TableCarouselStyle.speed

`float` `100`

轮播速度。

### TableCarouselStyle.type

[TableCarouselType](#tablecarouseltype)

轮播类型。

可选：

- `Pixel`: 像素轮播。
- `Row`: 单行轮播。
- `Page`: 分页轮播。

### TableCarouselStyle.waitTime

`int` `2000`

轮播等待时间（ms）。

## TableCell

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent), [ITableCell](#itablecell)

表格的单元格数据。

### TableCell.boolValue

`bool`

当前数据的布尔值。当type为Bool时有效。

### TableCell.doubleValue

`double`

当前数据的双精度值。当type为Double时有效。

### TableCell.gameObjectValue

`GameObject`

当前数据的GameObject值。当type为GameObject时有效。

### TableCell.show

`bool` `true`

是否显示当前数据。

### TableCell.spriteValue

`Sprite`

当前数据的Sprite值。当type为Sprite时有效。

### TableCell.stringValue

`string`

当前数据的字符串值。当type为String时有效。

### TableCell.type

[DataType](#datatype)

当前数据的类型。

可选：

- `GameObject`: 
- `String`: 
- `Double`: 
- `Bool`: 
- `Sprite`: 

## TableColumn

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头内容和样式。

### TableColumn.content

`string`

列表头内容。

### TableColumn.dataLabelStyle

`LabelStyle`

当前列的数据文本样式。默认不启用，而是共用TableColumnHeaderStyle的defaultDataLabelStyle。

### TableColumn.headerLabelStyle

`LabelStyle`

当前列的列表头文本样式。默认不启用，而是共用TableColumnHeaderStyle的defalutHeaderLabelStyle。

### TableColumn.show

`bool` `true`

是否显示列表头。

### TableColumn.width

`float` `0f`

列宽。默认为0时列宽平分。

## TableColumnHeaderStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头样式。

### TableColumnHeaderStyle.background

`ImageStyle`

背景图片样式。

### TableColumnHeaderStyle.backgroundColor

`Color32`

列表头背景色。

### TableColumnHeaderStyle.borderStyle

`BorderStyle` `v3.10.0`

列表头边框样式。

### TableColumnHeaderStyle.defaultLabelStyle

`LabelStyle`

### TableColumnHeaderStyle.height

`float` `50f`

列表头高度。

### TableColumnHeaderStyle.opaque

`bool` `true` `v3.10.0`

列表头是否不透明。

### TableColumnHeaderStyle.show

`bool` `true`

是否显示列表头。

## TableColumnStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列样式。

### TableColumnStyle.columnBackgroundColors

`List<Color32>`

列背景颜色列表。

### TableColumnStyle.columnWidth

`float` `0f`

列宽。默认0，自适应。Columns中设置有时优先用Columns中的值，没有时用这个值。

### TableColumnStyle.defaultLabelStyle

`LabelStyle`

默认的列数据文本样式。

### TableColumnStyle.minColumnWidth

`float` `100f`

最小列宽。

### TableColumnStyle.show

`bool` `true`

是否显示列。

## TableRow

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格的行数据。

### TableRow.data

`List<TableCell>`

行数据列表。

### TableRow.height

`float`

当前行的自定义高度。默认为0不自定义。

### TableRow.name

`string`

行名称。可用于显示在行表头，用通配符{name}。

### TableRow.show

`bool` `true`

是否显示当前行。

## TableRowHeaderStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

行表头样式。

### TableRowHeaderStyle.backgroundColor

`Color32`

背景色。

### TableRowHeaderStyle.labelStyle

`LabelStyle`

文本样式。

### TableRowHeaderStyle.show

`bool` `true`

是否显示行表头。

### TableRowHeaderStyle.width

`float` `100f`

宽度。

## TableRowStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

行样式。

### TableRowStyle.borderStyle

`BorderStyle` `v3.10.0`

行边框样式。

### TableRowStyle.minRowHeight

`float` `30f`

最小行高。

### TableRowStyle.rowBackgroundColors

`List<Color32>`

行背景颜色列表。

### TableRowStyle.rowGap

`float` `0f`

行间距。

### TableRowStyle.rowHeight

`float` `0f`

行高。

### TableRowStyle.show

`bool` `true`

是否显示行。

## TableScrollbarStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格滚动条样式。

### TableScrollbarStyle.backgroundColor

`Color32`

滚动条背景色。

### TableScrollbarStyle.borderStyle

`BorderStyle` `v3.10.0`

滚动条的边框样式。

### TableScrollbarStyle.color

`Color32`

滚动条颜色。

### TableScrollbarStyle.horizontal

`bool` `false`

是否显示水平滚动条。

### TableScrollbarStyle.show

`bool` `false`

是否开启滚动条。

### TableScrollbarStyle.vertical

`bool` `true`

是否显示垂直滚动条。

### TableScrollbarStyle.width

`float` `10`

滚动条宽度。

## TableSeparatorStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

表格分割线样式。

### TableSeparatorStyle.horizontal

`bool` `true`

是否显示水平分割线。

### TableSeparatorStyle.horizontalColor

`Color32` `Color.clear`

水平分割线的颜色。

### TableSeparatorStyle.horizontalColumn

`bool` `true`

是否显示列表头的水平分割线。

### TableSeparatorStyle.horizontalWidth

`float` `1f`

水平分割线的宽度。

### TableSeparatorStyle.show

`bool` `true`

是否显示分割线。

### TableSeparatorStyle.vertical

`bool` `true`

是否显示垂直分割线。

### TableSeparatorStyle.verticalColor

`Color32` `Color.clear`

垂直分割线的颜色。

### TableSeparatorStyle.verticalColumn

`bool` `true`

是否显示列表头的垂直分割线。

### TableSeparatorStyle.verticalWidth

`float` `1f`

垂直分割线的宽度。

## UIImage

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

ui component of image. 图片UI组件。

## UIStatistic

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

### UIStatistic.animationStyle

`AnimationStyle`

起始动画。

### UIStatistic.valueLabelStyle

`LabelStyle`

## UITable

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

表格UI组件。 用于展示行列数据。

### UITable.borderStyle

`BorderStyle`

表格边框样式。

### UITable.carouselStyle

[TableCarouselStyle](#tablecarouselstyle)

轮播样式。

### UITable.columnHeaderStyle

[TableColumnHeaderStyle](#tablecolumnheaderstyle)

默认的列头样式。

### UITable.columns

`List<TableColumn>`

列表头样式。

### UITable.columnStyle

[TableColumnStyle](#tablecolumnstyle)

列样式。

### UITable.data

`List<TableRow>`

表格数据。

### UITable.rowHeaderStyle

[TableRowHeaderStyle](#tablerowheaderstyle)

行表头样式。

### UITable.rowStyle

[TableRowStyle](#tablerowstyle)

行样式。

### UITable.scrollbarStyle

[TableScrollbarStyle](#tablescrollbarstyle)

滚动条样式。

### UITable.scrollSensitivity

`float` `10f`

滚动灵敏度。

### UITable.selectColor

`Color32`

选中时的颜色。

### UITable.selectHeaderColor

`Color32`

选中时表头的颜色。

### UITable.separatorStyle

[TableSeparatorStyle](#tableseparatorstyle)

分割线样式。

### UITable.supportDrag

`bool` `false`

是否支持拖拽。

### UITable.supportScroll

`bool` `true`

是否支持滚动。

### UITable.supportSelect

`bool` `true`

是否支持选中。选中行，列，单元格。

## UITimePicker

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。
