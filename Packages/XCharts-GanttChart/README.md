# XCharts-GanttChart

XCharts的付费扩展图表 - GanttChart 甘特图。

## Serie-Gantt

甘特图系列。支持类目轴和时间轴的甘特图，当 `X` 轴为类目轴时，数据为类目的索引，`X` 轴为时间轴时，数据为时间戳（秒为单位）。`Y` 轴默认为类目轴，显示的数据来源于`Serie`的`Data`的`Name`。
甘特图默认支持开始和结束时间，也可以额外支持实际开始和结束时间。

* `show`：系列是否显示在图表上。
* `type`：`Gantt`。
* `name`：系列名称。用于 `tooltip` 的显示，`legend` 的图例筛选。
* `xAxisIndex`：使用的坐标轴X轴的 `index`，在单个图表实例中存在多个坐标轴的时候有用。
* `yAxisIndex`：使用的坐标轴Y轴的 `index`，在单个图表实例中存在多个坐标轴的时候有用。
* `clip`：是否裁剪超出坐标系部分的图形。
* `large`：是否开启大数据量优化，在数据图形特别多而出现卡顿时候可以开启。开启后配合 largeThreshold 在数据量大于指定阈值的时候对绘制进行优化。缺点：优化后不能自定义设置单个数据项的样式，不能显示Label，折线图不绘制Symbol。
* `largeThreshold`：开启大数量优化的阈值。只有当开启了large并且数据量大于该阀值时才进入性能模式。
* `itemStyle`：甘特图的柱条样式，包括设置背景颜色和边框等 [ItemStyle](#ItemStyle)。
* `emphasis`：高亮样式 [Emphasis](#Emphasis)。
* `animation`：起始动画 [SerieAnimation](#SerieAnimation)。
* `data`：系列中的数据项 [SerieData](#SerieData) 数组，甘特图至少需要2个维度的数组`[start, end]`，也支持4个维度的数组`[start, end, actualStart, actualEnd]`。当 X 轴为类目轴时，数据为类目的索引，X 轴为时间轴时，数据为时间戳（秒为单位）。