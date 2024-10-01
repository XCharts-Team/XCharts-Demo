# API

## Pie3D

class in XCharts.Runtime.Pie3Ds / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

serie of 3D pie.

### Pie3D.defaultColorBy

public override SerieColorBy defaultColorBy  

### Pie3D.AddDefaultSerie

public static Serie AddDefaultSerie(BaseChart chart, string serieName)  

### Pie3D.ConvertSerie

public static Pie3D ConvertSerie(Serie serie)  

## Pie3DChart

class in XCharts.Runtime.Pie3Ds / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

3D pie.

### Pie3DChart.DefaultAutoHeightPie3DChart

public void DefaultAutoHeightPie3DChart()  
generate default 3d auto height pie chart.

### Pie3DChart.DefaultDonutPie3DChart

public void DefaultDonutPie3DChart()  
generate default 3d donut pie chart.

### Pie3DChart.DefaultEllipsePie3DChart

public void DefaultEllipsePie3DChart()  
generate default 2d ellipse pie chart.

## Pie3DSlice

class in XCharts.Runtime.Pie3Ds

Slice of pie.

### Pie3DSlice.Contains

public bool Contains(float angle)  

### Pie3DSlice.IsInPolygon

public bool IsInPolygon(Vector2 p)  

### Pie3DSlice.IsInSidePolygon

public bool IsInSidePolygon(Vector2 p)  

### Pie3DSlice.IsInStartOrEndSide

public bool IsInStartOrEndSide(Vector2 p)  

### Pie3DSlice.IsInTopPolygon

public bool IsInTopPolygon(Vector2 p)  

### Pie3DSlice.Pie3DSlice

public Pie3DSlice()  

### Pie3DSlice.UpdateValue

public void UpdateValue(int index, float start, float end, bool startSide, bool endSide, float maxHig)  

## Pie3DStyle

class in XCharts.Runtime.Pie3Ds / Inherits from: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

Pie 3d style.

### Pie3DStyle.drawSplitSide

public bool drawSplitSide  
whether draw split side. When pieAutoHeight is true, this value is invalid.

### Pie3DStyle.ellipseMinorAxis

public float ellipseMinorAxis  
The minor axis length of ellipse.

### Pie3DStyle.endSideColorRate

public float endSideColorRate  
The end side color rate of 3d pie.

### Pie3DStyle.peripherySideColorRate

public float peripherySideColorRate  
The periphery side color rate of 3d pie.

### Pie3DStyle.pieAutoHeight

public bool pieAutoHeight  
Whether auto set 3d pie height by data rate.

### Pie3DStyle.pieMaxHeight

public float pieMaxHeight  
The max height of 3d pie.

### Pie3DStyle.selectedOffset

public Vector2 selectedOffset  
The offset of selected pie slice.

### Pie3DStyle.startSideColorRate

public float startSideColorRate  
The start side color rate of 3d pie.

