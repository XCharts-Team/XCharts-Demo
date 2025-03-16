# API

## Context

class in XCharts.Runtime.UI

### Context.fillStyle

public FillStyle fillStyle  
进度条填充样式。

### Context.labelStyle

public LabelStyle labelStyle  
进度条标签样式。

### Context.max

public float max  

### Context.min

public float min  
进度条最小值。

### Context.step

public float step  
进度条步长。

### Context.type

public Type type  
进度条类型。

### Context.value

public float value  
进度条当前值。

### Context.DefaultCircle

public void DefaultCircle()  

## Context.Type

class in XCharts.Runtime.UI

进度条类型。

可选：

- `Line`: 水平进度条。
- `Circle`: 圆形进度条。

## DataType

class in XCharts.Runtime.UI

可选：

- `GameObject`: 
- `String`: 
- `Double`: 
- `Bool`: 
- `Sprite`: 

## FillStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

填充样式。

### FillStyle.autoOffset

public bool autoOffset  
是否自动偏移填充位置。当为true时，会自动根据显示的文本或滑块大小自动进行左右缩进。

### FillStyle.background

public Background background  
背景样式。

### FillStyle.color

public Color32 color  
填充颜色。

### FillStyle.height

public float height  
填充高度。优先级比top和bottom高。在环形进度条中表示环的宽度。

### FillStyle.location

public Location location  
填充位置。

### FillStyle.radius

public float radius  
填充半径。只在环形进度条中有效。

### FillStyle.roundCap

public bool roundCap  
是否使用圆角。只在环形进度条中有效。

### FillStyle.show

public bool show  
是否显示填充。

### FillStyle.toColor

public Color32 toColor  
渐变结束颜色。

### FillStyle.width

public float width  
填充宽度。优先级比left和right高。

## HandleStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

> 从 `v3.13.0` 开始支持

滑块样式。

### HandleStyle.gradientColor

public bool gradientColor  
是否使用渐变颜色。滑动条设置渐变颜色时才生效。

### HandleStyle.show

public bool show  
是否显示滑块。

### HandleStyle.symbol

public SymbolStyle symbol  
图形样式。

## ITableCell

class in XCharts.Runtime.UI / 子类: [TableCell](#tablecell) 

## MarkStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

> 从 `v3.13.0` 开始支持

标记样式。

### MarkStyle.fillStyle

public FillStyle fillStyle  
填充样式。

### MarkStyle.handleStyle

public HandleStyle handleStyle  
滑块样式。

### MarkStyle.included

public bool included  
是否包含在范围内。为true时，标记显示为进度条颜色，否则显示为背景颜色。

### MarkStyle.interactable

public bool interactable  
是否可交互。

### MarkStyle.label

public LabelStyle label  
文本样式。

### MarkStyle.markNames

public List&lt;string&gt; markNames  
标志名称。当指定有标志名称时，标记的文本会尝试从这里取。

### MarkStyle.markStyle

public MarkStyle markStyle  
标记样式。

### MarkStyle.markValues

public List&lt;float&gt; markValues  
标记值。当指定有标志值时，会在指定位置显示标记和文本。

### MarkStyle.max

public float max  
最大值。滑块值不能大于最大值。

### MarkStyle.min

public float min  
最小值。滑块值不能小于最小值。

### MarkStyle.onRangeChanged

public Action&lt;float, float&gt; onRangeChanged  
滑块范围改变时的回调。

### MarkStyle.onRangeChangedComplete

public Action&lt;float, float&gt; onRangeChangedComplete  
滑块范围改变完成时的回调。

### MarkStyle.onValueChanged

public Action&lt;float&gt; onValueChanged  
滑块值改变时的回调。

### MarkStyle.onValueChangedComplete

public Action&lt;float&gt; onValueChangedComplete  
滑块值改变完成时的回调。

### MarkStyle.show

public bool show  
是否显示标记。

### MarkStyle.step

public float step  
步长。滑块值会按照步长变化。

### MarkStyle.symbol

public SymbolStyle symbol  
图形样式。

### MarkStyle.value

public float[] value  
滑块当前值。这是一个二维数组，当为范围值类型时，两个值分别表示最小值和最大值，其他类型时只用第二个值。

### MarkStyle.OnBeginDrag

public override void OnBeginDrag(PointerEventData eventData)  

### MarkStyle.OnDrag

public override void OnDrag(PointerEventData eventData)  

### MarkStyle.OnEndDrag

public override void OnEndDrag(PointerEventData eventData)  

### MarkStyle.OnPointerClick

public override void OnPointerClick(PointerEventData eventData)  

### MarkStyle.SetValue

public void SetValue(float rangeMin, float rangeMax)  
设置当前范围值。

public void SetValue(float rangeMin, float rangeMax, float min, float max)  
设置当前范围值和最大最小值。

public void SetValue(float value, float min, float max)  
设置当前值和最大最小值。


## MarkStyle.value and the enum type.

class in XCharts.Runtime.UI

可选：

- `public void SetValue(float value`: 设置当前枚举值和枚举类型。
- `if (!enumType.IsEnum) return;`: 设置当前枚举值和枚举类型。
- `valueType = ValueType.Enum;`: 设置当前枚举值和枚举类型。
- `value[0] = 0;`: 设置当前枚举值和枚举类型。
- `value[1] = value;`: 设置当前枚举值和枚举类型。
- `var fields = enumType.GetFields(BindingFlags.Public | BindingFlags.Static);`: 设置当前枚举值和枚举类型。
- `markValues.Clear();`: 设置当前枚举值和枚举类型。
- `markNames.Clear();`: 设置当前枚举值和枚举类型。
- `foreach (var field in fields)`: 设置当前枚举值和枚举类型。
- `var v = (int)field.GetValue(null);`: 设置当前枚举值和枚举类型。
- `if (m_Min > v) m_Min = v;`: 设置当前枚举值和枚举类型。
- `if (m_Max < v) m_Max = v;`: 设置当前枚举值和枚举类型。
- `markValues.Add(v);`: 设置当前枚举值和枚举类型。
- `markNames.Add(field.Name);`: 设置当前枚举值和枚举类型。

## MarkStyle.value.

class in XCharts.Runtime.UI

可选：


## StatisticContext

class in XCharts.Runtime.UI

## StatisticHelper

class in XCharts.Runtime.UI

### StatisticHelper.GetContentPosition

public static Vector3 GetContentPosition(UIStatistic statistic)  

### StatisticHelper.GetTitleContent

public static string GetTitleContent(UIStatistic statistic, double value)  

### StatisticHelper.GetValueContent

public static string GetValueContent(UIStatistic statistic, double value)  

## TableCarouselContext

class in XCharts.Runtime.UI

## TableCarouselMode

class in XCharts.Runtime.UI

轮播播放模式。

可选：

- `Loop`: 循环播放。

## TableCarouselStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格轮播样式。

## TableCarouselType

class in XCharts.Runtime.UI

表格轮播类型。

可选：

- `Pixel`: 像素轮播。
- `Row`: 单行轮播。
- `Page`: 分页轮播。

## TableCell

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent),[ITableCell](#itablecell)

表格的单元格数据。

### TableCell.GetContent

public string GetContent()  
获取当前数据的内容。

## TableColumn

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列表头内容和样式。

## TableColumnHeaderStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列表头样式。

### TableColumnHeaderStyle.background

public ImageStyle background  
背景图片样式。

### TableColumnHeaderStyle.backgroundColor

public Color32 backgroundColor  
列表头背景色。

### TableColumnHeaderStyle.height

public float height  
列表头高度。

### TableColumnHeaderStyle.opaque

public bool opaque  
列表头是否不透明。

## TableColumnStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

列样式。

### TableColumnStyle.columnBackgroundColors

public List&lt;Color32&gt; columnBackgroundColors  
列背景颜色列表。

## TableContext

class in XCharts.Runtime.UI

表格运行时上下文。

## TableHelper

class in XCharts.Runtime.UI

表格帮助类。

### TableHelper.ClampVectorMin

public static void ClampVectorMin(float minX, ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 p4)  

### TableHelper.GetAllColumnWidth

public static float GetAllColumnWidth(UITable table)  

### TableHelper.GetAllRowAndGapHeight

public static float GetAllRowAndGapHeight(UITable table)  

### TableHelper.GetAllRowHeight

public static float GetAllRowHeight(UITable table)  

### TableHelper.GetBackgroundColor

public static Color32 GetBackgroundColor(UITable table)  

### TableHelper.GetCarouselProgress

public static float GetCarouselProgress(UITable table)  

### TableHelper.GetColumnAutoEachWidth

public static float GetColumnAutoEachWidth(UITable table)  

### TableHelper.GetColumnHeaderBackgroundColor

public static Color32 GetColumnHeaderBackgroundColor(UITable table)  

### TableHelper.GetColumnHeaderHeight

public static float GetColumnHeaderHeight(UITable table)  

### TableHelper.GetColumnWidth

public static float GetColumnWidth(UITable table, int columnIndex, float eachWidth = 0)  

### TableHelper.GetDataLabelStyle

public static LabelStyle GetDataLabelStyle(UITable table, int index)  

### TableHelper.GetHeaderLabelStyle

public static LabelStyle GetHeaderLabelStyle(UITable table, int index)  

### TableHelper.GetHorizontalSeparatorColor

public static Color32 GetHorizontalSeparatorColor(UITable table)  

### TableHelper.GetRowAutoEachHeight

public static float GetRowAutoEachHeight(UITable table)  

### TableHelper.GetRowBackgroundColor

public static Color32 GetRowBackgroundColor(UITable table, int index)  

### TableHelper.GetRowHeaderBgColor

public static Color32 GetRowHeaderBgColor(UITable table, int rowIndex)  

### TableHelper.GetRowHeaderContent

public static string GetRowHeaderContent(UITable table, int i)  
表格帮助类。

### TableHelper.GetRowHeaderWidth

public static float GetRowHeaderWidth(UITable table)  

### TableHelper.GetRowHeight

public static float GetRowHeight(UITable table, int rowIndex, float eachHeight = 0)  

### TableHelper.GetScrollbarBackgroundColor

public static Color32 GetScrollbarBackgroundColor(UITable table)  

### TableHelper.GetScrollbarColor

public static Color32 GetScrollbarColor(UITable table)  

### TableHelper.GetScrollbarHorizontalRange

public static float GetScrollbarHorizontalRange(UITable table)  

### TableHelper.GetScrollbarHorizontalRate

public static float GetScrollbarHorizontalRate(UITable table)  

### TableHelper.GetScrollbarHorizontalWidth

public static float GetScrollbarHorizontalWidth(UITable table)  

### TableHelper.GetScrollbarVerticalRange

public static float GetScrollbarVerticalRange(UITable table)  

### TableHelper.GetScrollbarVerticalRate

public static float GetScrollbarVerticalRate(UITable table)  

### TableHelper.GetScrollbarVerticalWidth

public static float GetScrollbarVerticalWidth(UITable table)  

### TableHelper.GetSelectColor

public static Color32 GetSelectColor(UITable table)  

### TableHelper.GetSelectHeaderColor

public static Color32 GetSelectHeaderColor(UITable table)  

### TableHelper.GetVerticalSeparatorColor

public static Color32 GetVerticalSeparatorColor(UITable table)  

### TableHelper.IsNeedDrawColumnHeader

public static bool IsNeedDrawColumnHeader(UITable table)  

### TableHelper.IsNeedDrawRowHeader

public static bool IsNeedDrawRowHeader(UITable table)  

## TableRow

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格的行数据。

## TableRowHeaderStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

行表头样式。

## TableRowStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

行样式。

### TableRowStyle.rowBackgroundColors

public List&lt;Color32&gt; rowBackgroundColors  
行背景颜色列表。

## TableScrollbarStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格滚动条样式。

## TableSeparatorStyle

class in XCharts.Runtime.UI / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

表格分割线样式。

### TableSeparatorStyle.IsNeedDrawHorizontalSeparator

public bool IsNeedDrawHorizontalSeparator()  
是否需要绘制水平分割线。

### TableSeparatorStyle.IsNeedDrawVerticalSeparator

public bool IsNeedDrawVerticalSeparator()  
是否需要绘制垂直分割线。

## UIImage

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

ui component of image. 图片UI组件。

## UIProgress

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

## UISlider

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

> 从 `v3.13.0` 开始支持

UI滑动型输入组件，展示当前值和可选范围。

## UISlider.ValueType

class in XCharts.Runtime.UI

值类型。

可选：

- `Default`: 默认值。
- `Range`: 范围值。
- `Enum`: 枚举值。

## UIStatistic

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

统计数值UI组件。 用于展示统计数值。当需要突出某个或某组数字时，或展示带描述的统计类数据时使用。

### UIStatistic.Type

public enum Type  

### UIStatistic.GetCurrentValue

public double GetCurrentValue(float animationDuration)  
获取当前时刻的数值。当有变更动画时，返回动画过程中的数值。

## UIStatistic.Type { Default, Countdown }

class in XCharts.Runtime.UI

可选：

- `[SerializeField] private Type m_Type = Type.Default;`: 
- `[SerializeField] private string m_Title = "";`: 
- `[SerializeField] private double m_Value;`: 
- `[SerializeField] private float m_ItemGap = 5;`: 
- `[SerializeField] private Location m_Location = Location.defaultTop;`: 

## UISvgImage

class in XCharts.Runtime / 继承自: [MaskableGraphic](https://docs.unity3d.com/ScriptReference/30_search.html?q=maskablegraphic)

### UISvgImage.mirrorY

public bool mirrorY  

### UISvgImage.svgPath

public string svgPath  

## UITable

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

表格UI组件。 用于展示行列数据。

### UITable.borderStyle

public BorderStyle borderStyle  
表格边框样式。

### UITable.carouselStyle

public TableCarouselStyle carouselStyle  
轮播样式。

### UITable.columnCount

public int columnCount  
列数。

### UITable.columnHeaderStyle

public TableColumnHeaderStyle columnHeaderStyle  
默认的列头样式。

### UITable.columns

public List&lt;TableColumn&gt; columns  
列表头样式。

### UITable.columnStyle

public TableColumnStyle columnStyle  
列样式。

### UITable.data

public List&lt;TableRow&gt; data  
表格数据。

### UITable.rowCount

public int rowCount  
行数。

### UITable.rowHeaderStyle

public TableRowHeaderStyle rowHeaderStyle  
行表头样式。

### UITable.rowStyle

public TableRowStyle rowStyle  
行样式。

### UITable.scrollbarStyle

public TableScrollbarStyle scrollbarStyle  
滚动条样式。

### UITable.separatorStyle

public TableSeparatorStyle separatorStyle  
分割线样式。

### UITable.AddColumn

public void AddColumn(string title, List&lt;double&gt; data)  
添加一列double类型数据。

public void AddColumn(string title, List&lt;Sprite&gt; data)  
添加一列Sprite类型数据。

public void AddColumn(string title, List&lt;string&gt; data)  
添加一列string类型数据。

public void AddColumn(string title, params double[] data)  
添加一列double类型数据。

public void AddColumn(string title, params Sprite[] data)  
添加一列Sprite类型数据。


### UITable.AddRow

public void AddRow(params string[] row)  
添加一行数据。


### UITable.ClearColumns

public void ClearColumns()  
清除Columns数据。

### UITable.ClearData

public void ClearData()  
清除Data数据。

### UITable.GetContent

public string GetContent(int row, int column)  
获取指定行列的单元格内容。

### UITable.GetData

public TableCell GetData(int row, int column)  
获取指定行列的单元格数据。

### UITable.OnBeginDrag

public override void OnBeginDrag(PointerEventData eventData)  

### UITable.OnDrag

public override void OnDrag(PointerEventData eventData)  

### UITable.OnEndDrag

public override void OnEndDrag(PointerEventData eventData)  

### UITable.OnPointerClick

public override void OnPointerClick(PointerEventData eventData)  

### UITable.OnPointerEnter

public override void OnPointerEnter(PointerEventData eventData)  

### UITable.OnPointerExit

public override void OnPointerExit(PointerEventData eventData)  

### UITable.OnScroll

public override void OnScroll(PointerEventData eventData)  

### UITable.RefreshGraph

public override void RefreshGraph()  

### UITable.RefreshPosition

public virtual void RefreshPosition()  

### UITable.RefreshTable

public void RefreshTable()  
刷新表格。

### UITable.RemoveRow

public void RemoveRow(int rowIndex)  
删除一行数据。

### UITable.SetColumns

public void SetColumns(List&lt;string&gt; columns)  
设置列表头数据。

### UITable.SetColumnsAndData

public void SetColumnsAndData(List&lt;string&gt; columns, List&lt;List&lt;string&gt;&gt; rows)  
设置Columns和Data数据。

### UITable.SetData

public void SetData(List&lt;List&lt;string&gt;&gt; rows)  
设置Data数据。

### UITable.UpdateCell

public void UpdateCell(int row, int column, double value)  
更新一个单元格数据。

public void UpdateCell(int row, int column, Sprite value)  
更新一个单元格数据。


### UITable.UpdateColumn

public void UpdateColumn(int columnIndex, List&lt;double&gt; column)  
更新指定索引的列数据。

public void UpdateColumn(int columnIndex, List&lt;Sprite&gt; column)  
更新指定索引的列数据。

public void UpdateColumn(int columnIndex, params double[] column)  
更新指定索引的列数据。

public void UpdateColumn(int columnIndex, params Sprite[] column)  
更新指定索引的列数据。

public void UpdateColumn(int columnIndex, params string[] column)  
更新指定索引的列数据。


### UITable.UpdateRow

public void UpdateRow(int rowIndex, params string[] row)  
更新一行数据。


## UIText

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

> 从 `v3.13.0` 开始支持

ui component of text. UI文本组件。

## UITimePicker

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

时间选择UI组件。 输入或选择时间的控件。当用户需要输入一个时间，可以点击标准输入框，弹出时间面板进行选择。

## UIToggle

class in XCharts.Runtime.UI / 继承自: [UIComponent](https://xcharts-team.github.io/docs/api#uicomponent)

> 从 `v3.13.0` 开始支持

ui component of toggle. UI开关组件。

### UIToggle.borderStyle

public BorderStyle borderStyle  
边框样式。

### UIToggle.interactable

public bool interactable  
是否可交互。

### UIToggle.isOn

public bool isOn  
是否开启。

### UIToggle.labelStyle

public LabelStyle labelStyle  
文本样式。

### UIToggle.markColor

public Color32 markColor  
标记颜色。

### UIToggle.markGap

public float markGap  

### UIToggle.offColor

public Color32 offColor  

### UIToggle.onColor

public Color32 onColor  
开启时的颜色。

### UIToggle.onValueChanged

public Action&lt;bool&gt; onValueChanged  
开关值改变时的回调函数。

### UIToggle.text

public string text  
开关文本。

### UIToggle.OnPointerClick

public override void OnPointerClick(PointerEventData eventData)  

