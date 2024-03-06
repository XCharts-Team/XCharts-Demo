# API

## ITableCell

> class in XCharts.Runtime.UI / 子类: [TableCell](#tablecell) 


## StatisticContext

> class in XCharts.Runtime.UI


## StatisticHelper

> class in XCharts.Runtime.UI


|API|版本|描述|
|--|--|--|
|GetContentPosition()||public static Vector3 GetContentPosition(UIStatistic statistic)|
|GetTitleContent()||public static string GetTitleContent(UIStatistic statistic, double value)|
|GetValueContent()||public static string GetValueContent(UIStatistic statistic, double value)|

## TableCarouselContext

> class in XCharts.Runtime.UI


## TableCarouselStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格轮播样式。

## TableCell

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent),[ITableCell](#itablecell)

表格的单元格数据。

|API|版本|描述|
|--|--|--|
|GetContent()||public string GetContent()<br/>获取当前数据的内容。 |

## TableColumn

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列表头内容和样式。

## TableColumnHeaderStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列表头样式。

## TableColumnStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列样式。

## TableContext

> class in XCharts.Runtime.UI

表格运行时上下文。

## TableHelper

> class in XCharts.Runtime.UI

表格帮助类。

|API|版本|描述|
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

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格的行数据。

## TableRowHeaderStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

行表头样式。

## TableRowStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

行样式。

## TableScrollbarStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格滚动条样式。

## TableSeparatorStyle

> class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格分割线样式。

|API|版本|描述|
|--|--|--|
|IsNeedDrawHorizontalSeparator()||public bool IsNeedDrawHorizontalSeparator()<br/>是否需要绘制水平分割线。 |
|IsNeedDrawVerticalSeparator()||public bool IsNeedDrawVerticalSeparator()<br/>是否需要绘制垂直分割线。 |

## UIImage

> class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

ui component of image. 图片UI组件。

## UIProgress

> class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)


## UIStatistic

> class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

|API|版本|描述|
|--|--|--|
|GetCurrentValue()||public double GetCurrentValue(float animationDuration)<br/>获取当前时刻的数值。当有变更动画时，返回动画过程中的数值。 |

## UISvgImage

> class in XCharts.Runtime / 继承自: [MaskableGraphic](https://docs.unity3d.com/ScriptReference/30_search.html?q=maskablegraphic)


## UITable

> class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

表格UI组件。 用于展示行列数据。

|API|版本|描述|
|--|--|--|
|AddColumn()||public void AddColumn(string title, List&lt;double&gt; data)<br/>添加一列double类型数据。 |
|AddColumn()||public void AddColumn(string title, List&lt;Sprite&gt; data)<br/>添加一列Sprite类型数据。 |
|AddColumn()||public void AddColumn(string title, List&lt;string&gt; data)<br/>添加一列string类型数据。 |
|AddColumn()||public void AddColumn(string title, params double[] data)<br/>添加一列double类型数据。 |
|AddColumn()||public void AddColumn(string title, params Sprite[] data)<br/>添加一列Sprite类型数据。 |
|AddColumn()||public void AddColumn(string title, params string[] data)<br/>添加一列string类型数据。 |
|AddRow()||public void AddRow(List&lt;string&gt; row)<br/>添加一行数据。 |
|AddRow()||public void AddRow(params string[] row)<br/>添加一行数据。 |
|ClearColumns()||public void ClearColumns()<br/>清除Columns数据。 |
|ClearData()||public void ClearData()<br/>清除Data数据。 |
|GetContent()||public string GetContent(int row, int column)<br/>获取指定行列的单元格内容。 |
|GetData()||public TableCell GetData(int row, int column)<br/>获取指定行列的单元格数据。 |
|OnDrag()||public override void OnDrag(PointerEventData eventData)|
|OnPointerClick()||public override void OnPointerClick(PointerEventData eventData)|
|OnPointerEnter()||public override void OnPointerEnter(PointerEventData eventData)|
|OnPointerExit()||public override void OnPointerExit(PointerEventData eventData)|
|OnScroll()||public override void OnScroll(PointerEventData eventData)|
|RefreshGraph()||public override void RefreshGraph()|
|RefreshPosition()||public virtual void RefreshPosition()|
|RefreshTable()||public void RefreshTable()<br/>刷新表格。 |
|RemoveRow()||public void RemoveRow(int rowIndex)<br/>删除一行数据。 |
|SetColumns()||public void SetColumns(List&lt;string&gt; columns)<br/>设置列表头数据。 |
|SetColumnsAndData()||public void SetColumnsAndData(List&lt;string&gt; columns, List&lt;List&lt;string&gt;&gt; rows)<br/>设置Columns和Data数据。 |
|SetData()||public void SetData(List&lt;List&lt;string&gt;&gt; rows)<br/>设置Data数据。 |
|UpdateCell()||public void UpdateCell(int row, int column, double value)<br/>更新一个单元格数据。 |
|UpdateCell()||public void UpdateCell(int row, int column, Sprite value)<br/>更新一个单元格数据。 |
|UpdateCell()||public void UpdateCell(int row, int column, string value)<br/>更新一个单元格数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;double&gt; column)<br/>更新指定索引的列数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;Sprite&gt; column)<br/>更新指定索引的列数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, List&lt;string&gt; column)<br/>更新指定索引的列数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params double[] column)<br/>更新指定索引的列数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params Sprite[] column)<br/>更新指定索引的列数据。 |
|UpdateColumn()||public void UpdateColumn(int columnIndex, params string[] column)<br/>更新指定索引的列数据。 |
|UpdateRow()||public void UpdateRow(int rowIndex, List&lt;string&gt; row)<br/>更新一行数据。 |
|UpdateRow()||public void UpdateRow(int rowIndex, params string[] row)<br/>更新一行数据。 |

## UITimePicker

> class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

