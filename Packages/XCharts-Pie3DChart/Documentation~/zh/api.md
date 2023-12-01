# API

## Pie3D

> class in XCharts.Runtime.Pie3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)


|API|版本|描述|
|--|--|--|
|AddDefaultSerie()||public static Serie AddDefaultSerie(BaseChart chart, string serieName)|
|ConvertSerie()||public static Pie3D ConvertSerie(Serie serie)|

## Pie3DChart

> class in XCharts.Runtime.Pie3Ds / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

3D饼图。

## Pie3DSlice

> class in XCharts.Runtime.Pie3Ds

3D饼图的切块。

|API|版本|描述|
|--|--|--|
|Contains()||public bool Contains(float angle)|
|IsInPolygon()||public bool IsInPolygon(Vector2 p)|
|IsInSidePolygon()||public bool IsInSidePolygon(Vector2 p)|
|IsInStartOrEndSide()||public bool IsInStartOrEndSide(Vector2 p)|
|IsInTopPolygon()||public bool IsInTopPolygon(Vector2 p)|
|Pie3DSlice()||public Pie3DSlice()|
|UpdateValue()||public void UpdateValue(int index, float start, float end, bool startSide, bool endSide, float maxHig)|

## Pie3DStyle

> class in XCharts.Runtime.Pie3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

3D饼图样式。

