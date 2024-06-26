# API

## Liquid

> class in XCharts.Runtime.Liquids / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)


|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static Serie AddDefaultSerie(BaseChart chart, string serieName)|

## LiquidChart

> class in XCharts.Runtime.Liquids / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

水位图

|public method|since|description|
|--|--|--|
|DefaultCapsuleLiquidChart()||public void DefaultCapsuleLiquidChart()<br/>generate default capsule liquid chart. 生成默认的胶囊形水位图。 |
|DefaultRectLiquidChart()||public void DefaultRectLiquidChart()<br/>generate default rect liquid chart. 生成默认的矩形水位图。 |
|DefaultRoundRectLiquidChart()||public void DefaultRoundRectLiquidChart()<br/>generate default round rect liquid chart. 生成默认的圆角矩形水位图。 |

## Vessel

> class in XCharts.Runtime.Liquids / Inherits from: [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent),[ISerieContainer](https://xcharts-team.github.io/docs/api#iseriecontainer),[IUpdateRuntimeData](https://xcharts-team.github.io/docs/api#iupdateruntimedata)

Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

|public method|since|description|
|--|--|--|
|IsPointerEnter()||public bool IsPointerEnter()|
|UpdateRuntimeData()||public void UpdateRuntimeData(BaseChart chart)|

## VesselContext

> class in XCharts.Runtime.Liquids / Inherits from: [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)


