# API

## Gauge

class in XCharts.Runtime.Gauges / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)

仪表盘系列数据。

### Gauge.defaultColorBy

public override SerieColorBy defaultColorBy  

### Gauge.AddDefaultSerie

public static void AddDefaultSerie(BaseChart chart, string serieName)  

### Gauge.ClearComponentDirty

public override void ClearComponentDirty()  

### Gauge.ClearVerticesDirty

public override void ClearVerticesDirty()  

### Gauge.GetPointerColor

public Color32 GetPointerColor(ThemeStyle theme, int colorIndex, float angle, Color32 dataColor)  

## GaugeAnchor

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

### GaugeAnchor.GetPosition

public Vector3 GetPosition(Vector3 center, float radius)  

## GaugeAxis

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

仪表盘轴线相关设置。

### GaugeAxis.axisLabel

public AxisLabel axisLabel  
文本标签。

### GaugeAxis.axisLabelText

public List&lt;string&gt; axisLabelText  
自定义Label的内容。

### GaugeAxis.axisLine

public GaugeAxisLine axisLine  
仪表盘轴线样式。

### GaugeAxis.axisTick

public AxisTick axisTick  
刻度。

### GaugeAxis.distance

public float distance  

### GaugeAxis.overlap

public bool overlap  

### GaugeAxis.show

public bool show  

### GaugeAxis.splitLine

public AxisSplitLine splitLine  
分割线。

### GaugeAxis.type

public GaugeAxisType type  

### GaugeAxis.AddLabelObject

public void AddLabelObject(ChartLabel label)  

### GaugeAxis.ClearLabelObject

public void ClearLabelObject()  

### GaugeAxis.GaugeAxis

public GaugeAxis()  

### GaugeAxis.GetLabelObject

public ChartLabel GetLabelObject(int index)  

### GaugeAxis.GetStageColor

public Color32 GetStageColor(float rate)  

### GaugeAxis.GetStageColorByAngle

public Color32 GetStageColorByAngle(float angle)  

### GaugeAxis.SetLabelObjectActive

public void SetLabelObjectActive(bool flag)  

### GaugeAxis.SetLabelObjectPosition

public void SetLabelObjectPosition(int index, Vector3 pos)  

### GaugeAxis.SetLabelObjectText

public void SetLabelObjectText(int index, string text)  

## GaugeAxisLine

class in XCharts.Runtime.Gauges / 继承自: [BaseLine](https://xcharts-team.github.io/docs/api#baseline)

### GaugeAxisLine.backgroundColor

public Color32 backgroundColor  
进度条背景颜色。

### GaugeAxisLine.stageColor

public List&lt;StageColor&gt; stageColor  
阶段颜色。

### GaugeAxisLine.stageGradient

public bool stageGradient  
阶段颜色是否渐变过渡。

### GaugeAxisLine.GaugeAxisLine

public GaugeAxisLine(bool show) : base(show)  

## GaugeAxisType

class in XCharts.Runtime.Gauges

仪表盘类型

可选：

- `None`: 仪表盘类型
- `Section`: 分段
- `Progress`: 进度

## GaugeChart

class in XCharts.Runtime.Gauges / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

仪表盘。

### GaugeChart.DefaultBarometerGaugeChart

public void DefaultBarometerGaugeChart()  
生成气压计仪表盘。

### GaugeChart.DefaultClockGaugeChart

public void DefaultClockGaugeChart()  
生成时钟仪表盘。

### GaugeChart.DefaultMultipleGaugeChart

public void DefaultMultipleGaugeChart()  
生成多仪表盘。

### GaugeChart.DefaultProgressGaugeChart

public void DefaultProgressGaugeChart()  
生成进度仪表盘。

### GaugeChart.DefaultRangeClockGaugeChart

public void DefaultRangeClockGaugeChart()  

### GaugeChart.DefaultSectionGaugeChart

public void DefaultSectionGaugeChart()  
生成分段仪表盘。

### GaugeChart.UpdateClockTime

public void UpdateClockTime(double hour, double minute, double second)  
更新时钟时间。


### GaugeChart.UpdatePointerValue

public void UpdatePointerValue(double value)  
更新指针值。

## GaugePointer

class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

仪表盘指针相关设置。

