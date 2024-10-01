# Configuration

## Liquid

class in XCharts.Runtime.Liquids / Inherits from: [Serie](https://xcharts-team.github.io/docs/configuration#serie), [INeedSerieContainer](https://xcharts-team.github.io/docs/configuration#ineedseriecontainer)

### Liquid.waveHeight

`float` `10f`

波高。

### Liquid.waveLength

`float` `20f`

Wave length of the wave, which is relative to the diameter.

### Liquid.waveOffset

`float` `0f`

波偏移。

### Liquid.waveSpeed

`float` `5f`

波速。正数时左移，负数时右移。

## Vessel

class in XCharts.Runtime.Liquids / Inherits from: [MainComponent](https://xcharts-team.github.io/docs/configuration#maincomponent), [ISerieContainer](https://xcharts-team.github.io/docs/configuration#iseriecontainer), [IUpdateRuntimeData](https://xcharts-team.github.io/docs/configuration#iupdateruntimedata)

Vessel component for liquid chart. There can be multiple vessels in a Chart, which can be matched by vesselIndex in Serie.

### Vessel.autoColor

`bool` `true`

Whether automatic color. If true, the color matches serie.

### Vessel.backgroundColor

`Color32`

Background color of polar, which is transparent by default.

### Vessel.borderColor

`Color32` `Color32(70, 70, 240, 255)`

The color on inside of vessel. The default is consistent with Serie.

### Vessel.borderWidth

`float` `0f`

The border on the inside of vessel.

### Vessel.center

`float[]`

The center of vesselß. The center[0] is the x-coordinate, and the center[1] is the y-coordinate.

### Vessel.color

`Color32` `Color32(70, 70, 240, 255)`

Vessel color. The default is consistent with Serie.

### Vessel.cornerRadius

`float[]`

The radius of rounded corner. Its unit is px. Use array to respectively specify the 4 corner radiuses((clockwise upper left, upper right, bottom right and bottom left)).

### Vessel.gap

`float` `5f`

The gap between the vessel and the liquid.

### Vessel.height

`float` `0.7f`

The height of vessel.

### Vessel.radius

`float` `0.35f`

The radius of vessel.

### Vessel.shape

[Vessel.Shape](#vesselshape)

The shape of vessel.

Options:

- `Circle`: 圆形
- `Rect`: 正方形。
- `Triangle`: 三角形。
- `Diamond`: 菱形。

### Vessel.shapeWidth

`float` `5f`

Thickness of vessel.

### Vessel.show

`bool` `true`

Whether to show the vessel.

### Vessel.smoothness

`float` `1f`

The smoothness of wave.

### Vessel.width

`float` `0.5f`

The width of vessel.
