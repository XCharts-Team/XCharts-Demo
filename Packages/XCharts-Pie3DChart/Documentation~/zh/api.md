# API

## Pie3D

class in XCharts.Runtime.Pie3Ds / 继承自: [Serie](https://xcharts-team.github.io/docs/api#serie)

3D饼图系列。

### Pie3D.defaultColorBy

public override SerieColorBy defaultColorBy  

### Pie3D.AddDefaultSerie

public static Serie AddDefaultSerie(BaseChart chart, string serieName)  

### Pie3D.ConvertSerie

public static Pie3D ConvertSerie(Serie serie)  

## Pie3DChart

class in XCharts.Runtime.Pie3Ds / 继承自: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

3D饼图。

### Pie3DChart.DefaultAutoHeightPie3DChart

public void DefaultAutoHeightPie3DChart()  
生成默认3D自动高度饼图。

### Pie3DChart.DefaultDonutPie3DChart

public void DefaultDonutPie3DChart()  
生成默认3D甜甜圈饼图。

### Pie3DChart.DefaultEllipsePie3DChart

public void DefaultEllipsePie3DChart()  
生成默认2D椭圆饼图。

## Pie3DSlice

class in XCharts.Runtime.Pie3Ds

3D饼图的切块。

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

class in XCharts.Runtime.Pie3Ds / 继承自: [ChildComponent](https://xcharts-team.github.io/docs/api#childcomponent)

3D饼图样式。

### Pie3DStyle.drawSplitSide

public bool drawSplitSide  
是否绘制分割面。当pieAutoHeight为true时，该值无效。

### Pie3DStyle.ellipseMinorAxis

public float ellipseMinorAxis  
椭圆的短轴长度。当为0-1的浮点数时为长轴的百分比。

### Pie3DStyle.endSideColorRate

public float endSideColorRate  
饼图切块的结束面颜色（顺时针）。

### Pie3DStyle.peripherySideColorRate

public float peripherySideColorRate  
饼图切块的侧面颜色。

### Pie3DStyle.pieAutoHeight

public bool pieAutoHeight  
是否自动根据比例计算厚度。

### Pie3DStyle.pieMaxHeight

public float pieMaxHeight  
饼图厚度。

### Pie3DStyle.selectedOffset

public Vector2 selectedOffset  
被选中状态的饼图块的额外偏移。

### Pie3DStyle.startSideColorRate

public float startSideColorRate  
饼图切块的起始面颜色（顺时针）。

