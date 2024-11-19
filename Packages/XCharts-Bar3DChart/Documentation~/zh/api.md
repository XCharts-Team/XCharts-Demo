# API

## Bar3D

class in XCharts.Runtime.Bar3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)

3D柱图。支持立方柱和圆柱。可水平排列和垂直排列。

### Bar3D.containerIndex

public int containerIndex  

### Bar3D.containterInstanceId

public int containterInstanceId  

### Bar3D.AddDefaultSerie

public static Bar3D AddDefaultSerie(BaseChart chart, string serieName)  

### Bar3D.ConvertSerie

public static Bar3D ConvertSerie(Serie serie)  

## Bar3DChart

class in XCharts.Runtime.Bar3Ds / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

### Bar3DChart.DefaultCylinderChart

public void DefaultCylinderChart()  
生成默认的圆柱体图。

### Bar3DChart.DefaultGroupedCubeChart

public void DefaultGroupedCubeChart()  
默认分组3D柱状图。

### Bar3DChart.DefaultStackedCubeChart

public void DefaultStackedCubeChart()  
默认堆叠分组3D柱状图。

## Bar3DStyle

class in XCharts.Runtime.Bar3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

## Bar3DType

class in XCharts.Runtime.Bar3Ds

3D柱图类型。分为立方柱和圆柱。

可选：

- `Cube`: 立方柱。
- `Cylinder`: 圆柱。

