# API

## Treemap

class in XCharts.Runtime.Treemaps / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

### Treemap.customGoUpLevelButton

public GameObject customGoUpLevelButton  
自定义返回上一层按钮，自定义的按钮需要自己处理点击事件，调用GoUpALevel()接口。

### Treemap.drillDownIcon

public string drillDownIcon  
当节点可以下钻时的提示符，只能是字符。默认为▶

### Treemap.leafDepth

public int leafDepth  
默认显示的几层节点。默认为0时表示尽可能展示多层节点，设置大于0时，下钻功能开启，需要点击后才展示子节点。

### Treemap.levelStyle

public LevelStyle levelStyle  

### Treemap.upperLabel

public LabelStyle upperLabel  
父节点标签。show为true时表示显示父节点标签，margin参数设置子节点和父节点的间距。

### Treemap.visualDimension

public int visualDimension  
用于计算占比的数据维数。

### Treemap.AddDefaultSerie

public static void AddDefaultSerie(BaseChart chart, string serieName)  

### Treemap.CanGoUpALevel

public bool CanGoUpALevel()  
是否可以返回上一层

### Treemap.GetLevelItemStyle

public ItemStyle GetLevelItemStyle(int level)  

### Treemap.GetLevelLabel

public LabelStyle GetLevelLabel(int level)  

### Treemap.GetLevelUpperLabel

public LabelStyle GetLevelUpperLabel(int level)  

### Treemap.GoUpALevel

public void GoUpALevel()  
返回上一层

### Treemap.OnDataUpdate

public override void OnDataUpdate()  

### Treemap.SetSelectedSerieData

public bool SetSelectedSerieData(string serieDataName)  
设置选中（要展示的）的数据名


## TreemapChart

class in XCharts.Runtime.Treemaps / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

