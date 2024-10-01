# API

## Gauge

class in XCharts.Runtime.Gauges / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

serie of gauge chart.

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

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

### GaugeAnchor.GetPosition

public Vector3 GetPosition(Vector3 center, float radius)  

## GaugeAxis

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

Settings related to gauge axis line.

### GaugeAxis.axisLabel

public AxisLabel axisLabel  
axis label style.

### GaugeAxis.axisLabelText

public List&lt;string&gt; axisLabelText  
Coordinate axis scale label custom content. When the content is empty, `axisLabel` automatically displays the content according to the scale; otherwise, the content is taken from the list definition.

### GaugeAxis.axisLine

public GaugeAxisLine axisLine  
axis line style.

### GaugeAxis.axisTick

public AxisTick axisTick  
axis tick style.

### GaugeAxis.distance

public float distance  

### GaugeAxis.overlap

public bool overlap  

### GaugeAxis.show

public bool show  

### GaugeAxis.splitLine

public AxisSplitLine splitLine  
slit line style.

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

class in XCharts.Runtime.Gauges / Inherits from: [BaseLine](https://xcharts-team.github.io/docs/api#baseline)

### GaugeAxisLine.backgroundColor

public Color32 backgroundColor  
The background color of gauge axis.

### GaugeAxisLine.stageColor

public List&lt;StageColor&gt; stageColor  
The colors of stage.

### GaugeAxisLine.stageGradient

public bool stageGradient  
Whether to use gradients for transitions.

### GaugeAxisLine.GaugeAxisLine

public GaugeAxisLine(bool show) : base(show)  

## GaugeAxisType

class in XCharts.Runtime.Gauges

仪表盘类型

Options:

- `None`: 仪表盘类型
- `Section`: 分段
- `Progress`: 进度

## GaugeChart

class in XCharts.Runtime.Gauges / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

Gauge chart.

### GaugeChart.DefaultBarometerGaugeChart

public void DefaultBarometerGaugeChart()  
generate barometer gauge chart.

### GaugeChart.DefaultClockGaugeChart

public void DefaultClockGaugeChart()  
generate clock gauge chart.

### GaugeChart.DefaultMultipleGaugeChart

public void DefaultMultipleGaugeChart()  
generate multiple gauge chart.

### GaugeChart.DefaultProgressGaugeChart

public void DefaultProgressGaugeChart()  
generate progress gauge chart.

### GaugeChart.DefaultRangeClockGaugeChart

public void DefaultRangeClockGaugeChart()  

### GaugeChart.DefaultSectionGaugeChart

public void DefaultSectionGaugeChart()  
generate section gauge chart.

### GaugeChart.UpdateClockTime

public void UpdateClockTime(double hour, double minute, double second)  
update clock time.


### GaugeChart.UpdatePointerValue

public void UpdatePointerValue(double value)  
update pointer value.

## GaugePointer

class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

Settings related to gauge pointer.

