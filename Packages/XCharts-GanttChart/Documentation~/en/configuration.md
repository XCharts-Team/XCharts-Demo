# Configuration

## Gantt

class in XCharts.Runtime.Gantts / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

### Gantt.disableDrag

`bool`

## GanttStyle

class in XCharts.Runtime.Gantts / Inherits from: [MainComponent](https://xcharts-team.github.io/docs/configuration#maincomponent)

### GanttStyle.aliginLine

`LineStyle`

对齐线样式。

### GanttStyle.alignlineDataIndex

`int` `1`

显示对齐线的数据项索引。

### GanttStyle.autoAdsorbAlignline

`bool` `true`

拖拽结束后是否自动吸附到对齐线。

### GanttStyle.dragEnable

`bool` `true`

是否可以拖拽甘特图。

### GanttStyle.dragRangeMax

`double` `0`

拖拽最大值限制。

### GanttStyle.dragRangeMin

`double` `0`

拖拽最小值限制。

### GanttStyle.dragSensitivity

`float` `1f`

拖拽的灵敏度。

### GanttStyle.ganttType

[GanttType](#gantttype)

The type of gantt.

Options:

- `Monomial`: 单项甘特图。每个数据项都是单独的一条进度。
- `Multinomial`: 多项甘特图。每个数据项只是一条进度里的一段。

### GanttStyle.invert

`bool` `true`

### GanttStyle.show

`bool` `true`

### GanttStyle.showAlignlineRange

`float` `10f`

显示对齐线的范围。

### GanttStyle.splitArea

`AxisSplitArea`
