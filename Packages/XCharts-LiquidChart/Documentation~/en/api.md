# API

## Liquid

class in XCharts.Runtime.Liquids / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie),[INeedSerieContainer](https://xcharts-team.github.io/docs/api#ineedseriecontainer)

### Liquid.containerIndex

public int containerIndex  

### Liquid.containterInstanceId

public int containterInstanceId  

### Liquid.AddDefaultSerie

public static Serie AddDefaultSerie(BaseChart chart, string serieName)  

## LiquidChart

class in XCharts.Runtime.Liquids / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

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

class in XCharts.Runtime.Liquids / Inherits from: [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent),[ISerieContainer](https://xcharts-team.github.io/docs/api#iseriecontainer),[IUpdateRuntimeData](https://xcharts-team.github.io/docs/api#iupdateruntimedata)

Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

### Vessel.IsPointerEnter

public bool IsPointerEnter()  

### Vessel.UpdateRuntimeData

public void UpdateRuntimeData(BaseChart chart)  

## Vessel.Shape

class in XCharts.Runtime.Liquids

Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

Options:

- `Circle`: 圆形
- `Rect`: 正方形。
- `Triangle`: 三角形。
- `Diamond`: 菱形。

## VesselContext

class in XCharts.Runtime.Liquids / Inherits from: [MainComponentContext](https://xcharts-team.github.io/docs/api#maincomponentcontext)

### VesselContext.center

public Vector3 center  
the runtime center position of vessel.

### VesselContext.height

public float height  

### VesselContext.innerRadius

public float innerRadius  
The actual radius after deducting shapeWidth and gap.

### VesselContext.isPointerEnter

public bool isPointerEnter  

### VesselContext.radius

public float radius  
the runtime radius of vessel.

### VesselContext.width

public float width  

