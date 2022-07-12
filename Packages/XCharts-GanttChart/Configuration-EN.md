# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Gantt](#Gantt)

## MainComponent

- [GanttStyle](#GanttStyle)

## `Gantt`

Inherits or Implemented: [Serie](#Serie)

|field|default|since|comment|
|--|--|--|--|
|`disableDrag`|||

## `GanttStyle`

Inherits or Implemented: [MainComponent](#MainComponent)

|field|default|since|comment|
|--|--|--|--|
|`show`|true||
|`ganttType`|||The type of gantt.</br>`GanttType`:</br>- `Monomial`: 单项甘特图。每个数据项都是单独的一条进度。</br>- `Multinomial`: 多项甘特图。每个数据项只是一条进度里的一段。</br>|
|`invert`|true||
|`dragEnable`|true||是否可以拖拽甘特图。
|`dragSensitivity`|1f||拖拽的灵敏度。
|`dragRangeMin`|0||拖拽最小值限制。
|`dragRangeMax`|0||拖拽最大值限制。
|`autoAdsorbAlignline`|true||拖拽结束后是否自动吸附到对齐线。
|`alignlineDataIndex`|1||显示对齐线的数据项索引。
|`showAlignlineRange`|10f||显示对齐线的范围。
|`aliginLine`|||对齐线样式。
|`splitArea`|||

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
