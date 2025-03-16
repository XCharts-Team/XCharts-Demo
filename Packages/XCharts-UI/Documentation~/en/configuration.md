# Configuration

## FillStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

Style of fill.

### FillStyle.autoOffset

`bool` `true`

Whether to automatically offset the fill position. When true, it will automatically indent left and right according to the displayed text or slider size.

### FillStyle.background

`Background`

Background style.

### FillStyle.color

`Color32` `Color32(145, 202, 255, 255)`

Fill color.

### FillStyle.height

`float` `5f`

Height of fill. Higher priority than top and bottom. Represents the width of the ring in the circular progress bar.

### FillStyle.location

`Location`

Location of fill.

### FillStyle.radius

`float` `0f`

Fill radius. Only valid in circular progress bar.

### FillStyle.roundCap

`bool` `true`

Whether to use round cap. Only valid in circular progress bar.

### FillStyle.show

`bool` `true`

Whether to show fill.

### FillStyle.toColor

`Color32` `Color32(0, 0, 0, 0)`

To color.

### FillStyle.width

`float`

Width of fill.

## HandleStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

> Since `v3.13.0`

Style of handle.

### HandleStyle.gradientColor

`bool` `false`

Whether to use gradient color.

### HandleStyle.show

`bool` `true`

Whether to show handle.

### HandleStyle.symbol

`SymbolStyle`

Style of symbol.

## ITableCell

class in XCharts.Runtime.UI / Subclasses: [TableCell](#tablecell)

## MarkStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

> Since `v3.13.0`

Style of mark.

### MarkStyle.fillStyle

[FillStyle](#fillstyle)

Style of fill.

### MarkStyle.handleStyle

[HandleStyle](#handlestyle)

Style of handle.

### MarkStyle.included

`bool` `true`

Whether to include in the range. When true, the mark is displayed as the progress bar color, otherwise it is displayed as the background color.

### MarkStyle.interactable

`bool` `true`

Whether the slider is interactable.

### MarkStyle.label

`LabelStyle`

Style of label.

### MarkStyle.markNames

`List<string>`

Names of marks. When specified with mark values, the mark and text are displayed at the specified position.

### MarkStyle.markStyle

[MarkStyle](#markstyle)

Style of mark.

### MarkStyle.markValues

`List<float>`

Values of marks. When specified with mark names, the mark and text are displayed at the specified position.

### MarkStyle.max

`float` `100`

Maximum value. The slider value cannot be greater than the maximum value.

### MarkStyle.min

`float` `0`

Minimum value. The slider value cannot be less than the minimum value.

### MarkStyle.show

`bool` `true`

Whether to show handle.

### MarkStyle.step

`float` `1`

Step size. The value of the slider will change by step size.

### MarkStyle.symbol

`SymbolStyle`

Style of symbol.

### MarkStyle.value

`float[]`

Current value of the slider. This is a two-dimensional array. When it is a range value type, the two values represent the minimum and maximum values respectively, and when it is other types, only the second value is used.

### MarkStyle.valueType

`ValueType`

Type of value. Support default value, range value, enum value.

## TableCarouselStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The table carousel style.

### TableCarouselStyle.hoverPause

`bool` `true`

Whether to pause when hover.

### TableCarouselStyle.mode

[TableCarouselMode](#tablecarouselmode)

The play mode of carousel.

Options:

- `Loop`: play loop.

### TableCarouselStyle.pause

`bool` `false`

pause carousel.

### TableCarouselStyle.show

`bool` `true`

### TableCarouselStyle.speed

`float` `100`

The carousel speed.

### TableCarouselStyle.type

[TableCarouselType](#tablecarouseltype)

The carousel type.

Options:

- `Pixel`: pixel carousel.
- `Row`: single row carousel.
- `Page`: page carousel.

### TableCarouselStyle.waitTime

`int` `2000`

wait time of carousel (ms).

## TableCell

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent), [ITableCell](#itablecell)

表格的单元格数据。

### TableCell.boolValue

`bool`

the bool data. when type is Bool.

### TableCell.doubleValue

`double`

the double data. when type is Double.

### TableCell.gameObjectValue

`GameObject`

the gameobject data. when type is GameObject.

### TableCell.show

`bool` `true`

whether the cell is visible.

### TableCell.spriteValue

`Sprite`

the sprite data. when type is Sprite.

### TableCell.stringValue

`string`

the string data. when type is String.

### TableCell.type

[DataType](#datatype)

the type of the cell data.

Options:

- `GameObject`: 
- `String`: 
- `Double`: 
- `Bool`: 
- `Sprite`: 

## TableColumn

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

列表头内容和样式。

### TableColumn.content

`string`

the content of the column header.

### TableColumn.dataLabelStyle

`LabelStyle`

the style of the column header. default not enabled, but use the defaultHeaderLabelStyle of TableColumnHeaderStyle.

### TableColumn.headerLabelStyle

`LabelStyle`

the style of the column header. default not enabled, but use the defaultHeaderLabelStyle of TableColumnHeaderStyle.

### TableColumn.show

`bool` `true`

whether the column is visible.

### TableColumn.width

`float` `0f`

the width of the column. when width is 0, the width is average.

## TableColumnHeaderStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table column header.

### TableColumnHeaderStyle.background

`ImageStyle`

the background style of the column header.

### TableColumnHeaderStyle.backgroundColor

`Color32`

the background color of the column header.

### TableColumnHeaderStyle.borderStyle

`BorderStyle` `v3.10.0`

the border style of the column header.

### TableColumnHeaderStyle.defaultLabelStyle

`LabelStyle`

### TableColumnHeaderStyle.height

`float` `50f`

the height of the column header.

### TableColumnHeaderStyle.opaque

`bool` `true` `v3.10.0`

whether the column header is opaque.

### TableColumnHeaderStyle.show

`bool` `true`

whether the column header is visible.

## TableColumnStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The style of table column.

### TableColumnStyle.columnBackgroundColors

`List<Color32>`

the background color of column.

### TableColumnStyle.columnWidth

`float` `0f`

the width of column. default 0, auto width. if set, it will be used first.

### TableColumnStyle.defaultLabelStyle

`LabelStyle`

the default style of the column label.

### TableColumnStyle.minColumnWidth

`float` `100f`

the min width of column.

### TableColumnStyle.show

`bool` `true`

whether the column is visible.

## TableRow

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the row data of the table.

### TableRow.data

`List<TableCell>`

the data list of the row.

### TableRow.height

`float`

the height of the row. default 0, auto height.

### TableRow.name

`string`

the name of the row. can be used to display in the row header, use wildcard \{name\}.

### TableRow.show

`bool` `true`

whether the row is visible.

## TableRowHeaderStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table row header.

### TableRowHeaderStyle.backgroundColor

`Color32`

the background color of the row header.

### TableRowHeaderStyle.labelStyle

`LabelStyle`

the style of the row header label.

### TableRowHeaderStyle.show

`bool` `true`

whether the row header is visible.

### TableRowHeaderStyle.width

`float` `100f`

the width of the row header.

## TableRowStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

The style of table row.

### TableRowStyle.borderStyle

`BorderStyle` `v3.10.0`

the border style of row.

### TableRowStyle.minRowHeight

`float` `30f`

the min height of row.

### TableRowStyle.rowBackgroundColors

`List<Color32>`

the background color of row.

### TableRowStyle.rowGap

`float` `0f`

the gap of row.

### TableRowStyle.rowHeight

`float` `0f`

the height of row.

### TableRowStyle.show

`bool` `true`

whether the row is visible.

## TableScrollbarStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table carousel.

### TableScrollbarStyle.backgroundColor

`Color32`

the background color of the scrollbar.

### TableScrollbarStyle.borderStyle

`BorderStyle` `v3.10.0`

the border style of the scrollbar.

### TableScrollbarStyle.color

`Color32`

the color of the scrollbar.

### TableScrollbarStyle.horizontal

`bool` `false`

whether to show the horizontal scrollbar.

### TableScrollbarStyle.show

`bool` `false`

whether the scrollbar is enable.

### TableScrollbarStyle.vertical

`bool` `true`

whether to show the vertical scrollbar.

### TableScrollbarStyle.width

`float` `10`

the width of the scrollbar.

## TableSeparatorStyle

class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/configuration#childcomponent)

the style of the table separator.

### TableSeparatorStyle.horizontal

`bool` `true`

whether to show the horizontal separator.

### TableSeparatorStyle.horizontalColor

`Color32` `Color.clear`

the color of horizontal separator.

### TableSeparatorStyle.horizontalColumn

`bool` `true`

whether to show the horizontal separator of the header.

### TableSeparatorStyle.horizontalWidth

`float` `1f`

the width of horizontal separator.

### TableSeparatorStyle.show

`bool` `true`

whether to show the separator.

### TableSeparatorStyle.vertical

`bool` `true`

whether to show the vertical separator.

### TableSeparatorStyle.verticalColor

`Color32` `Color.clear`

the color of vertical separator.

### TableSeparatorStyle.verticalColumn

`bool` `true`

whether to show the vertical separator of the header.

### TableSeparatorStyle.verticalWidth

`float` `1f`

the width of vertical separator.

## UIImage

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

ui component of image. 图片UI组件。

## UISlider

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

> Since `v3.13.0`

ui component of slider.

## UIStatistic

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

### UIStatistic.animationStyle

`AnimationStyle`

The start animation.

### UIStatistic.valueLabelStyle

`LabelStyle`

The style of value label.

## UITable

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

表格UI组件。 用于展示行列数据。

### UITable.borderStyle

`BorderStyle`

the border style of table.

### UITable.carouselStyle

[TableCarouselStyle](#tablecarouselstyle)

the style of carousel.

### UITable.columnHeaderStyle

[TableColumnHeaderStyle](#tablecolumnheaderstyle)

the default style of column header.

### UITable.columns

`List<TableColumn>`

the style of column header.

### UITable.columnStyle

[TableColumnStyle](#tablecolumnstyle)

the column style of table.

### UITable.data

`List<TableRow>`

the data of table.

### UITable.rowHeaderStyle

[TableRowHeaderStyle](#tablerowheaderstyle)

the style of row header.

### UITable.rowStyle

[TableRowStyle](#tablerowstyle)

the style of row.

### UITable.scrollbarStyle

[TableScrollbarStyle](#tablescrollbarstyle)

the style of scrollbar.

### UITable.scrollSensitivity

`float` `10f`

the scroll sensitivity.

### UITable.selectColor

`Color32`

the color of selected row, column, cell.

### UITable.selectHeaderColor

`Color32`

the color of selected header.

### UITable.separatorStyle

[TableSeparatorStyle](#tableseparatorstyle)

the style of separator.

### UITable.supportDrag

`bool` `false`

whether the table support drag.

### UITable.supportScroll

`bool` `true`

whether the table support scroll.

### UITable.supportSelect

`bool` `true`

whether the table support select. select row, column, cell.

## UIText

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

> Since `v3.13.0`

ui component of text. UI文本组件。

### UIText.text

`string`

The text content.

### UIText.textStyle

`TextStyle`

The text style.

## UITimePicker

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

## UIToggle

class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/configuration#uicomponent)

> Since `v3.13.0`

ui component of toggle. UI开关组件。

### UIToggle.borderStyle

`BorderStyle`

The border style of toggle.

### UIToggle.interactable

`bool` `true`

Whether the toggle is interactable.

### UIToggle.isOn

`bool` `false`

Whether the toggle is on.

### UIToggle.labelStyle

`LabelStyle`

The text style of toggle.

### UIToggle.markColor

`Color32` `Color32(255, 255, 255, 255)`

The color of mark.

### UIToggle.markGap

`float` `5f`

### UIToggle.offColor

`Color32` `Color32(198, 198, 198, 255)`

### UIToggle.onColor

`Color32` `Color32(83, 158, 241, 255)`

The color of toggle when it is on.

### UIToggle.text

`string`

The text of toggle.
