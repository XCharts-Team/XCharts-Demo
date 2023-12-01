# API

## ITableCell

> class in XCharts.Runtime.UI / Subclasses: [TableCell](#tablecell) 


## StatisticContext

> class in XCharts.Runtime.UI


## StatisticHelper

> class in XCharts.Runtime.UI


|public method|since|description|
|--|--|--|
|GetContentPosition()||public static Vector3 GetContentPosition(UIStatistic statistic)|
|GetTitleContent()||public static string GetTitleContent(UIStatistic statistic, double value)|
|GetValueContent()||public static string GetValueContent(UIStatistic statistic, double value)|

## TableCarouselContext

> class in XCharts.Runtime.UI


## TableCarouselStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

The table carousel style.

## TableCell

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent),[ITableCell](#itablecell)

表格的单元格数据。

|public method|since|description|
|--|--|--|
|GetContent()||public string GetContent()<br/>get the content of the cell. |

## TableColumn

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列表头内容和样式。

## TableColumnHeaderStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

the style of the table column header.

## TableColumnStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

The style of table column.

## TableContext

> class in XCharts.Runtime.UI

表格运行时上下文。

## TableHelper

> class in XCharts.Runtime.UI

表格帮助类。

|public method|since|description|
|--|--|--|
|ClampVectorMin()||public static void ClampVectorMin(float minX, ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 p4)|
|GetAllColumnWidth()||public static float GetAllColumnWidth(UITable table)|
|GetAllRowAndGapHeight()||public static float GetAllRowAndGapHeight(UITable table)|
|GetAllRowHeight()||public static float GetAllRowHeight(UITable table)|
|GetBackgroundColor()||public static Color32 GetBackgroundColor(UITable table)|
|GetCarouselProgress()||public static float GetCarouselProgress(UITable table)|
|GetColumnAutoEachWidth()||public static float GetColumnAutoEachWidth(UITable table)|
|GetColumnHeaderBackgroundColor()||public static Color32 GetColumnHeaderBackgroundColor(UITable table)|
|GetColumnHeaderHeight()||public static float GetColumnHeaderHeight(UITable table)|
|GetColumnWidth()||public static float GetColumnWidth(UITable table, int columnIndex, float eachWidth = 0)|
|GetDataLabelStyle()||public static LabelStyle GetDataLabelStyle(UITable table, int index)|
|GetHeaderLabelStyle()||public static LabelStyle GetHeaderLabelStyle(UITable table, int index)|
|GetHorizontalSeparatorColor()||public static Color32 GetHorizontalSeparatorColor(UITable table)|
|GetRowAutoEachHeight()||public static float GetRowAutoEachHeight(UITable table)|
|GetRowBackgroundColor()||public static Color32 GetRowBackgroundColor(UITable table, int index)|
|GetRowHeaderBgColor()||public static Color32 GetRowHeaderBgColor(UITable table, int rowIndex)|
|GetRowHeaderContent()||public static string GetRowHeaderContent(UITable table, int i)<br/>表格帮助类。 |
|GetRowHeaderWidth()||public static float GetRowHeaderWidth(UITable table)|
|GetRowHeight()||public static float GetRowHeight(UITable table, int rowIndex, float eachHeight = 0)|
|GetScrollbarBackgroundColor()||public static Color32 GetScrollbarBackgroundColor(UITable table)|
|GetScrollbarColor()||public static Color32 GetScrollbarColor(UITable table)|
|GetScrollbarHorizontalRange()||public static float GetScrollbarHorizontalRange(UITable table)|
|GetScrollbarHorizontalRate()||public static float GetScrollbarHorizontalRate(UITable table)|
|GetScrollbarHorizontalWidth()||public static float GetScrollbarHorizontalWidth(UITable table)|
|GetScrollbarVerticalRange()||public static float GetScrollbarVerticalRange(UITable table)|
|GetScrollbarVerticalRate()||public static float GetScrollbarVerticalRate(UITable table)|
|GetScrollbarVerticalWidth()||public static float GetScrollbarVerticalWidth(UITable table)|
|GetSelectColor()||public static Color32 GetSelectColor(UITable table)|
|GetSelectHeaderColor()||public static Color32 GetSelectHeaderColor(UITable table)|
|GetVerticalSeparatorColor()||public static Color32 GetVerticalSeparatorColor(UITable table)|
|IsNeedDrawColumnHeader()||public static bool IsNeedDrawColumnHeader(UITable table)|
|IsNeedDrawRowHeader()||public static bool IsNeedDrawRowHeader(UITable table)|

## TableRow

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

the row data of the table.

## TableRowHeaderStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

the style of the table row header.

## TableRowStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

The style of table row.

## TableScrollbarStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

the style of the table carousel.

## TableSeparatorStyle

> class in XCharts.Runtime.UI / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

the style of the table separator.

|public method|since|description|
|--|--|--|
|IsNeedDrawHorizontalSeparator()||public bool IsNeedDrawHorizontalSeparator()<br/>whether to need to draw the horizontal separator. |
|IsNeedDrawVerticalSeparator()||public bool IsNeedDrawVerticalSeparator()<br/>whether to need to draw the vertical separator. |

## UIProgress

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)


## UIStatistic

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

|public method|since|description|
|--|--|--|
|GetCurrentValue()||public double GetCurrentValue(float animationDuration)<br/>获取当前时刻的数值。当有变更动画时，返回动画过程中的数值。 |

## UITable

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

表格UI组件。 用于展示行列数据。

|public method|since|description|
|--|--|--|
|AddColumn()||public void AddColumn(string title, List&lt;double&gt; data)<br/>add a column data. |
|AddColumn()||public void AddColumn(string title, List&lt;Sprite&gt; data)<br/>add a column data. |
|AddColumn()||public void AddColumn(string title, List&lt;string&gt; data)<br/>add a column data. |
|AddColumn()||public void AddColumn(string title, params double[] data)<br/>add a column data. |
|AddColumn()||public void AddColumn(string title, params Sprite[] data)<br/>add a column data. |
|AddColumn()||public void AddColumn(string title, params string[] data)<br/>add a column data. |
|AddRow()||public void AddRow(List&lt;string&gt; row)<br/>add a row data. |
|AddRow()||public void AddRow(params string[] row)<br/>add a row data. |
|ClearColumns()||public void ClearColumns()<br/>clear the table columns. |
|ClearData()||public void ClearData()<br/>clear the table data. |
|GetContent()||public string GetContent(int row, int column)<br/>get the table cell content by row and column. |
|GetData()||public TableCell GetData(int row, int column)<br/>get the table cell data by row and column. |
|OnDrag()||public override void OnDrag(PointerEventData eventData)|
|OnPointerClick()||public override void OnPointerClick(PointerEventData eventData)|
|OnScroll()||public override void OnScroll(PointerEventData eventData)|
|RefreshGraph()||public override void RefreshGraph()|
|RefreshPosition()||public virtual void RefreshPosition()|
|RefreshTable()||public void RefreshTable()<br/>refresh the table. |
|RemoveRow()||public void RemoveRow(int rowIndex)<br/>remove a row data. |
|SetColumns()||public void SetColumns(List&lt;string&gt; columns)<br/>set the table columns. |
|SetColumnsAndData()||public void SetColumnsAndData(List&lt;string&gt; columns, List&lt;List&lt;string&gt;&gt; rows)<br/>set the table columns and data. |
|SetData()||public void SetData(List&lt;List&lt;string&gt;&gt; rows)<br/>set the table data. |
|UpdateCell()||public void UpdateCell(int row, int column, double value)<br/>update a cell data. |
|UpdateCell()||public void UpdateCell(int row, int column, Sprite value)<br/>update a cell data. |
|UpdateCell()||public void UpdateCell(int row, int column, string value)<br/>update a cell data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;double&gt; column)<br/>update a column data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;Sprite&gt; column)<br/>update a column data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;string&gt; column)<br/>update a column data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params double[] column)<br/>update a column data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params Sprite[] column)<br/>update a column data. |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params string[] column)<br/>update a column data. |
|UpdateRow()||public void UpdateRow(int rowIndex, List&lt;string&gt; row)<br/>upate a row data. |
|UpdateRow()||public void UpdateRow(int rowIndex, params string[] row)<br/>update a row data. |

## UITimePicker

> class in XCharts.Runtime.UI / Inherits from: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

