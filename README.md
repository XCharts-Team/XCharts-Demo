# XChartsDemo

XCharts3.0的Demo，仅包含内置图表部分，支持扩展图表Demo导入。

不支持XCharts2.0。

## 使用

项目使用`Unity2019.4.39f1`开发，下载项目后，使用相近的Unity版本打开即可。
Demo有发布WebGL版本（包含扩展图表部分），可以直接web运行查看效果：[WebGL Demo](https://xcharts-team.github.io/demo/)

![buildinchart](buildinchart.png)

## 扩展图表

Demo预留了扩展图表的导入，扩展图表是付费内容，默认不包含在项目里面。付费购买后可直接导入扩展图表的Package和Demo部分，即可在Demo里查看和运行扩展图表。

![extendchart](extendchart.png)

### 扩展图表如何导入到`XCharts-Demo`

以 `Pie3DChart` 为例：

1. 购买图表：购买扩展图表后，Github找到仓库 `XCharts-Pie3DChart`（私有仓库，购买后加入Team才可见）
2. 下载图表：选择和XCharts最接近的版本
3. 导入图表：将下载好的`XCharts-Pie3DChart`目录覆盖到`XCharts-Demo`项目中的`Packages/XCharts-Pie3DChart`
4. 下载图表Demo：Github找到仓库 `XCharts-Pie3DChart-Demo`并下载
5. 导入图表Demo：将下载好的`XCharts-Pie3DChart-Demo`目录覆盖到`XCharts-Demo`项目中的`Assets/XChartsExtensionDemo/XCharts-Pie3DChart-Demo`

### 扩展图表如何导入自己的项目中

以 `Pie3DChart` 为例：

1. 先确保项目中已导入`XCharts`
2. 再导入`XCharts-Pie3DChart`即可，不需要导入`XCharts-Pie3DChart-Demo`（如果要导入的话需要Unity版本接近2019.4.39f1）
