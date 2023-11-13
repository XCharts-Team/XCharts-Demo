# API

## Pie3D

> XCharts.Runtime.Pie3Ds.Pie3D : [Serie](https://xcharts-team.github.io/docs/api#serie)

|public method|since|description|
|--|--|--|
|AddDefaultSerie()||public static Serie AddDefaultSerie(BaseChart chart, string serieName)|
|ConvertSerie()||public static Pie3D ConvertSerie(Serie serie)|

## Pie3DChart

> XCharts.Runtime.Pie3Ds.Pie3DChart : [BaseChart](https://xcharts-team.github.io/docs/api#basechart)
3D pie.

## Pie3DSlice

> XCharts.Runtime.Pie3Ds.Pie3DSlice
Slice of pie.

|public method|since|description|
|--|--|--|
|Contains()||public bool Contains(float angle)|
|IsInPolygon()||public bool IsInPolygon(Vector2 p)|
|IsInSidePolygon()||public bool IsInSidePolygon(Vector2 p)|
|IsInStartOrEndSide()||public bool IsInStartOrEndSide(Vector2 p)|
|IsInTopPolygon()||public bool IsInTopPolygon(Vector2 p)|
|Pie3DSlice()||public Pie3DSlice()|
|UpdateValue()||public void UpdateValue(int index, float start, float end, bool startSide, bool endSide, float maxHig)|

## Pie3DStyle

> XCharts.Runtime.Pie3Ds.Pie3DStyle : [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)
Pie 3d style.

