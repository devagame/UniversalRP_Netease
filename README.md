# UniversalRP 自定义渲染管线扩展

[![Build](https://github.com/penrose/penrose/actions/workflows/build.yml/badge.svg)](https://github.com/zhanglongfei/UniversalRP/actions/workflows/blank.yml)  [![license](https://img.shields.io/github/license/devagame/universalrp)](LICENSE) [![Author](https://img.shields.io/badge/Unity-2021.3.1f1c1-blue.svg "")](https://github.com/devagame/ "") [![Author](https://img.shields.io/badge/UniversalRP-12.1.6+-blue.svg "")](https://github.com/devagame/ "")

本项目是 UniversalRP 的扩展库 支持自定义设置 URP 相机走 Gamma 还是 Linear 修复线性空间中的 UI 透明度差异问题, 能够让 UI 设计师在 Unity 中保持原有的 sRBG 工作流.

* [UICamera => Gamma]    <=>   [SceneCamera => Linear]

### Warning:
* Forward Renderer Data => Transparent Layer Mask 必须去掉 "UI" Layer Mask.

![image](https://user-images.githubusercontent.com/10047133/175798854-85108a5d-2dd0-4253-85fc-d7c092c434b4.png)

![image](https://user-images.githubusercontent.com/10047133/175798862-329777ef-6fad-4f26-98f4-14b4b8f9167b.png)
