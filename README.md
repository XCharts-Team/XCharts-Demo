# XCharts-Demo

Unity可视化图表插件[XCharts](https://github.com/XCharts-Team/XCharts) 的官方图表示例Demo，用于展示XCharts可以实现哪些功能和效果。

> 本Demo只支持XCharts 3.0，不支持XCharts 2.0。

> 本Demo只包含内置图表，扩展图表需要单独导入。

## 使用

本项目使用`Unity2019.4.39f1`开发，下载项目后，使用相近的Unity版本打开即可。
Demo有发布WebGL版本（包含扩展图表部分），可以直接浏览器看效果：[WebGL Demo](https://xcharts-team.github.io/demo/)

![buildinchart](buildinchart.png)

## 目录结构

|||
|--|--|
| Assets/Internal                       | Demo的内部资源和代码 |
| Assets/XCharts                        | XCharts需要的内置资源 |
| Assets/XChartsDemo                    | Demo示例目录，__要查看示例的主要关注这个目录__ |
| Assets/XChartsDemo/DemoConfig.asset   | Demo示例的各图表示例对应的prefab配置 |
| Assets/XChartsDemo/Charts             | 内置图表示例的prefab |
| Assets/XChartsExtensionDemo           | 扩展图表示例的prefab |

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
