# API

## Gauge

> class in XCharts.Runtime.Gauges / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)


|API|版本|描述|
|--|--|--|
|AddDefaultSerie()||public static void AddDefaultSerie(BaseChart chart, string serieName)|
|ClearComponentDirty()||public override void ClearComponentDirty()|
|ClearVerticesDirty()||public override void ClearVerticesDirty()|
|GetPointerColor()||public Color32 GetPointerColor(ThemeStyle theme, int colorIndex, float angle, Color32 dataColor)|

## GaugeAnchor

> class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)


|API|版本|描述|
|--|--|--|
|GetPosition()||public Vector3 GetPosition(Vector3 center, float radius)|

## GaugeAxis

> class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

仪表盘轴线相关设置。

|API|版本|描述|
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

> class in XCharts.Runtime.Gauges / 继承自: [BaseLine](https://xcharts-team.github.io/docs/api#baseline)


|API|版本|描述|
|--|--|--|
|GaugeAxisLine()||public GaugeAxisLine(bool show) : base(show)|

## GaugeChart

> class in XCharts.Runtime.Gauges / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)


## GaugePointer

> class in XCharts.Runtime.Gauges / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

仪表盘指针相关设置。

