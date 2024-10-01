# API

## Gantt

class in XCharts.Runtime.Gantts / Inherits from: [Serie](https://xcharts-team.github.io/docs/api#serie)

### Gantt.AddDefaultCategorySerie

public static void AddDefaultCategorySerie(BaseChart chart, string serieName)  

### Gantt.AddDefaultSerie

public static void AddDefaultSerie(BaseChart chart, string serieName)  

### Gantt.AddDefaultValueSerie

public static void AddDefaultValueSerie(BaseChart chart, string serieName)  

## GanttChart

class in XCharts.Runtime.Gantts / Inherits from: [BaseChart](https://xcharts-team.github.io/docs/api#basechart)

### GanttChart.aliginingValue

public double aliginingValue  

### GanttChart.runtimeBeginDrag

public bool runtimeBeginDrag  

### GanttChart.runtimeDragLeft

public bool runtimeDragLeft  

### GanttChart.runtimeDragSerie

public Serie runtimeDragSerie  

### GanttChart.runtimeDragSerieData

public SerieData runtimeDragSerieData  

### GanttChart.runtimeIsAlgining

public bool runtimeIsAlgining  

### GanttChart.runtimeIsDragSerie

public bool runtimeIsDragSerie  

### GanttChart.DefaultCategoryAxisGanttChart

public void DefaultCategoryAxisGanttChart()  
generate default category axis gantt chart.

### GanttChart.DefaultMonomialGroupGanttChart

public void DefaultMonomialGroupGanttChart()  
generate default monomial group gantt chart.

### GanttChart.DefaultMultinomialGroupGanttChart

public void DefaultMultinomialGroupGanttChart()  
generate default multinomial group gantt chart.

### GanttChart.DefaultValueAxisGanttChart

public void DefaultValueAxisGanttChart()  
generate default value axis gantt chart.

### GanttChart.GetSeriesMinMaxValue

public override void GetSeriesMinMaxValue(Axis axis, int axisIndex, out double tempMinValue, out double tempMaxValue)  

### GanttChart.InitAxisRuntimeData

public override void InitAxisRuntimeData(Axis axis)  

### GanttChart.OnBeginDrag

public override void OnBeginDrag(PointerEventData eventData)  

### GanttChart.OnDrag

public override void OnDrag(PointerEventData eventData)  

### GanttChart.OnEndDrag

public override void OnEndDrag(PointerEventData eventData)  

### GanttChart.OnPointerClick

public override void OnPointerClick(PointerEventData eventData)  

## GanttStyle

class in XCharts.Runtime.Gantts / Inherits from: [MainComponent](https://xcharts-team.github.io/docs/api#maincomponent)

## GanttType

class in XCharts.Runtime.Gantts

Options:

- `Monomial`: 单项甘特图。每个数据项都是单独的一条进度。
- `Multinomial`: 多项甘特图。每个数据项只是一条进度里的一段。

