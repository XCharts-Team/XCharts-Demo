# API

## Liquid

> class in XCharts.Runtime.Liquids / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)


|API|版本|描述|
|--|--|--|
|AddDefaultSerie()||public static Serie AddDefaultSerie(BaseChart chart, string serieName)|

## LiquidChart

> class in XCharts.Runtime.Liquids / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

水位图

## Vessel

> class in XCharts.Runtime.Liquids / 继承自: [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent),[ISerieContainer](https://xcharts-team.github.io/docs/api#iseriecontainer),[IUpdateRuntimeData](https://xcharts-team.github.io/docs/api#iupdateruntimedata)

容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

|API|版本|描述|
|--|--|--|
|IsPointerEnter()||public bool IsPointerEnter()|
|UpdateRuntimeData()||public void UpdateRuntimeData(BaseChart chart)|

## VesselContext

> class in XCharts.Runtime.Liquids / 继承自: [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)


