# API

## Liquid

> XCharts.Runtime.Liquids.Liquid : [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)

|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static Serie AddDefaultSerie(BaseChart chart, string serieName)|

## LiquidChart

> XCharts.Runtime.Liquids.LiquidChart : [BaseChart](https://xcharts-team.github.io/docs/api#basechart)
水位图

## Vessel

> XCharts.Runtime.Liquids.Vessel : [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent),[ISerieContainer](https://xcharts-team.github.io/docs/api#iseriecontainer),[IUpdateRuntimeData](https://xcharts-team.github.io/docs/api#iupdateruntimedata)
Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

|public method|since|description|
|--|--|--|
|IsPointerEnter()||public bool IsPointerEnter()|
|UpdateRuntimeData()||public void UpdateRuntimeData(BaseChart chart)|

## VesselContext

> XCharts.Runtime.Liquids.VesselContext : [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)

