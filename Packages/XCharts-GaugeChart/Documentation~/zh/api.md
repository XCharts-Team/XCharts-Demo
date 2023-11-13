# API

## Gauge

> XCharts.Runtime.Gauges.Gauge : [Serie](https://xcharts-team.github.io/docs/api#serie)

|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static void AddDefaultSerie(BaseChart chart, string serieName)|
|ClearComponentDirty()||public override void ClearComponentDirty()|
|ClearVerticesDirty()||public override void ClearVerticesDirty()|
|GetPointerColor()||public Color32 GetPointerColor(ThemeStyle theme, int colorIndex, float angle, Color32 dataColor)|

## GaugeAnchor

> XCharts.Runtime.Gauges.GaugeAnchor : [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

|public method|since|description|
|--|--|--|
|GetPosition()||public Vector3 GetPosition(Vector3 center, float radius)|

## GaugeAxis

> XCharts.Runtime.Gauges.GaugeAxis : [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)
仪表盘轴线相关设置。

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

> XCharts.Runtime.Gauges.GaugeAxisLine : [BaseLine](https://xcharts-team.github.io/docs/api#baseline)

|public method|since|description|
|--|--|--|
|GaugeAxisLine()||public GaugeAxisLine(bool show) : base(show)|

## GaugeChart

> XCharts.Runtime.Gauges.GaugeChart : [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

## GaugePointer

> XCharts.Runtime.Gauges.GaugePointer : [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)
仪表盘指针相关设置。

