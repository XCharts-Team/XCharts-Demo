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
容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

|public method|since|description|
|--|--|--|
|IsPointerEnter()||public bool IsPointerEnter()|
|UpdateRuntimeData()||public void UpdateRuntimeData(BaseChart chart)|

## VesselContext

> XCharts.Runtime.Liquids.VesselContext : [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)

