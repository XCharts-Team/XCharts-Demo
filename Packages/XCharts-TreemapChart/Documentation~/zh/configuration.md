# 配置项手册

## Treemap

class in XCharts.Runtime.Treemaps / 继承自: [Serie](https://xcharts-team.github.io/docs/configuration#serie)

### Treemap.customGoUpLevelButton

`GameObject`

自定义返回上一层按钮，自定义的按钮需要自己处理点击事件，调用GoUpALevel()接口。

### Treemap.drillDownIcon

`string`

当节点可以下钻时的提示符，只能是字符。默认为▶

### Treemap.leafDepth

`int` `0`

默认显示的几层节点。默认为0时表示尽可能展示多层节点，设置大于0时，下钻功能开启，需要点击后才展示子节点。

### Treemap.levelStyle

`LevelStyle`

### Treemap.upperLabel

`LabelStyle`

父节点标签。show为true时表示显示父节点标签，margin参数设置子节点和父节点的间距。

### Treemap.visualDimension

`int` `0`

用于计算占比的数据维数。
