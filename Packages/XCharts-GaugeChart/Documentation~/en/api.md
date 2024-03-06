# API

## Gauge

> class in XCharts.Runtime.Gauges / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

serie of gauge chart.

|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static void AddDefaultSerie(BaseChart chart, string serieName)|
|ClearComponentDirty()||public override void ClearComponentDirty()|
|ClearVerticesDirty()||public override void ClearVerticesDirty()|
|GetPointerColor()||public Color32 GetPointerColor(ThemeStyle theme, int colorIndex, float angle, Color32 dataColor)|

## GaugeAnchor

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)


|public method|since|description|
|--|--|--|
|GetPosition()||public Vector3 GetPosition(Vector3 center, float radius)|

## GaugeAxis

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

Settings related to gauge axis line.

|public method|since|description|
|--|--|--|
|AddLabelObject()||public void AddLabelObject(ChartLabel label)|
|ClearLabelObject()||public void ClearLabelObject()|
|GaugeAxis()||public GaugeAxis()|
|GetLabelObject()||public ChartLabel GetLabelObject(int index)|
|GetStageColor()||public Color32 GetStageColor(float rate)|
|GetStageColorByAngle()||public Color32 GetStageColorByAngle(float angle)|
|SetLabelObjectActive()||public void SetLabelObjectActive(bool flag)|
|SetLabelObjectPosition()||public void SetLabelObjectPosition(int index, Vector3 pos)|
|SetLabelObjectText()||public void SetLabelObjectText(int index, string text)|

## GaugeAxisLine

> class in XCharts.Runtime.Gauges / Inherits from: [BaseLine](https://xcharts-team.github.io/docs/api#baseline)


|public method|since|description|
|--|--|--|
|GaugeAxisLine()||public GaugeAxisLine(bool show) : base(show)|

## GaugeChart

> class in XCharts.Runtime.Gauges / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

Gauge chart.

|public method|since|description|
|--|--|--|
|DefaultBarometerGaugeChart()||public void DefaultBarometerGaugeChart()<br/>generate barometer gauge chart. |
|DefaultClockGaugeChart()||public void DefaultClockGaugeChart()<br/>generate clock gauge chart. |
|DefaultMultipleGaugeChart()||public void DefaultMultipleGaugeChart()<br/>generate multiple gauge chart. |
|DefaultProgressGaugeChart()||public void DefaultProgressGaugeChart()<br/>generate progress gauge chart. |
|DefaultRangeClockGaugeChart()||public void DefaultRangeClockGaugeChart()|
|DefaultSectionGaugeChart()||public void DefaultSectionGaugeChart()<br/>generate section gauge chart. |
|UpdateClockTime()||public void UpdateClockTime()<br/>update clock time. |
|UpdateClockTime()||public void UpdateClockTime(double hour, double minute, double second)<br/>update clock time. |
|UpdatePointerValue()||public void UpdatePointerValue(double value)<br/>update pointer value. |

## GaugePointer

> class in XCharts.Runtime.Gauges / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

Settings related to gauge pointer.

