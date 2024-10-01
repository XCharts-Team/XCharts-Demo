# API

## Liquid

class in XCharts.Runtime.Liquids / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)

### Liquid.containerIndex

public int containerIndex  

### Liquid.containterInstanceId

public int containterInstanceId  

### Liquid.AddDefaultSerie

public static Serie AddDefaultSerie(BaseChart chart, string serieName)  

## LiquidChart

class in XCharts.Runtime.Liquids / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

水位图

### LiquidChart.DefaultCapsuleLiquidChart

public void DefaultCapsuleLiquidChart()  
generate default capsule liquid chart. 生成默认的胶囊形水位图。

### LiquidChart.DefaultRectLiquidChart

public void DefaultRectLiquidChart()  
generate default rect liquid chart. 生成默认的矩形水位图。

### LiquidChart.DefaultRoundRectLiquidChart

public void DefaultRoundRectLiquidChart()  
generate default round rect liquid chart. 生成默认的圆角矩形水位图。

## Vessel

class in XCharts.Runtime.Liquids / 继承自: [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent),[ISerieContainer](https://xcharts-team.github.io/docs/api#iseriecontainer),[IUpdateRuntimeData](https://xcharts-team.github.io/docs/api#iupdateruntimedata)

容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

### Vessel.IsPointerEnter

public bool IsPointerEnter()  

### Vessel.UpdateRuntimeData

public void UpdateRuntimeData(BaseChart chart)  

## Vessel.Shape

class in XCharts.Runtime.Liquids

容器组件。 一般用于LiquidChart。一个Chart中可以有多个Vessel，Serie中用vesselIndex来对应。

可选：

- `Circle`: 圆形
- `Rect`: 正方形。
- `Triangle`: 三角形。
- `Diamond`: 菱形。

## VesselContext

class in XCharts.Runtime.Liquids / 继承自: [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)

### VesselContext.center

public Vector3 center  
运行时中心点。

### VesselContext.height

public float height  

### VesselContext.innerRadius

public float innerRadius  
运行时内半径。扣除厚度和间隙后的实际半径。

### VesselContext.isPointerEnter

public bool isPointerEnter  

### VesselContext.radius

public float radius  
运行时半径。

### VesselContext.width

public float width  

