# Chart Configuration

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)

## Serie

- [Treemap](#Treemap)

## `Treemap`

Inherits or Implemented: [Serie](#Serie)

|field|default|since|comment|
|--|--|--|--|
|`leafDepth`|0||默认显示的几层节点。默认为0时表示尽可能展示多层节点，设置大于0时，下钻功能开启，需要点击后才展示子节点。
|`visualDimension`|0||用于计算占比的数据维数。
|`drillDownIcon`|||当节点可以下钻时的提示符，只能是字符。默认为▶
|`customGoUpLevelButton`|||自定义返回上一层按钮，自定义的按钮需要自己处理点击事件，调用GoUpALevel()接口。
|`upperLabel`|||父节点标签。show为true时表示显示父节点标签，margin参数设置子节点和父节点的间距。
|`levelStyle`|||

[XCharts Homepage](https://github.com/XCharts-Team/XCharts)</br>
[XCharts API](XChartsAPI-EN.md)</br>
[XCharts FAQ](XChartsFAQ-EN.md)
