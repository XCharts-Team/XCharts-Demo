# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Liquid](#Liquid)

## MainComponent

- [Vessel](#Vessel)

## `Liquid`

Inherits or Implemented: [Serie](#Serie),[INeedSerieContainer](#INeedSerieContainer)

|field|default|since|comment|
|--|--|--|--|
|`waveHeight`|10f||波高。
|`waveLength`|20f||Wave length of the wave, which is relative to the diameter.
|`waveSpeed`|5f||波速。正数时左移，负数时右移。
|`waveOffset`|0f||波偏移。

## `Vessel`

Inherits or Implemented: [MainComponent](#MainComponent),[ISerieContainer](#ISerieContainer),[IUpdateRuntimeData](#IUpdateRuntimeData)

Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

|field|default|since|comment|
|--|--|--|--|
|`show`|true||Whether to show the vessel.
|`shape`|||The shape of vessel.</br>`Vessel.Shape`:</br>- `Circle`: 圆形</br>- `Rect`: 正方形。</br>- `Triangle`: 三角形。</br>- `Diamond`: 菱形。</br>|
|`shapeWidth`|5f||Thickness of vessel.
|`gap`|5f||The gap between the vessel and the liquid.
|`color`|Color32(70, 70, 240, 255)||Vessel color. The default is consistent with Serie.
|`backgroundColor`|||Background color of polar, which is transparent by default.
|`autoColor`|true||Whether automatic color. If true, the color matches serie.
|`center`|||The center of vesselß. The center[0] is the x-coordinate, and the center[1] is the y-coordinate.
|`radius`|0.35f||The radius of vessel.
|`smoothness`|1f||The smoothness of wave.
|`width`|0.5f||The width of vessel.
|`height`|0.7f||The height of vessel.
|`borderWidth`|0f||The border on the inside of vessel.
|`borderColor`|Color32(70, 70, 240, 255)||The color on inside of vessel. The default is consistent with Serie.
|`cornerRadius`|||The radius of rounded corner. Its unit is px. Use array to respectively specify the 4 corner radiuses((clockwise upper left, upper right, bottom right and bottom left)).

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
