# API Manager

[简体中文](/README_CN.md) | [English](/README.md)

本项目是 [SharwAPI](https://github.com/sharwapi/sharwapi.Core) 的官方核心管理插件。

它的主要职责是充当管理控制台的后端 API，允许管理员查看当前已加载的插件状态，并统一聚合挂载所有插件的管理端点（Management Endpoints）。

## 功能特性

- **插件检索**: 动态检索当前 API 实例中加载的所有插件信息（名称、版本、显示名称）。
- **路由聚合**: 自动遍历所有插件，将其定义的管理端点统一挂载到 `/admin/plugin/{插件名}/` 路径下，实现管理接口的统一入口。

## 安装与使用

1.  在 [Release](https://github.com/sharwapi/sharwapi.plugin.apimgr/releases) 获取插件编译后的 `.dll` 文件
2.  将其放入 API 本体的 `plugins` 目录中
3.  重启 API

## 许可证

本项目基于 [GNU Lesser General Public License v3.0](/LICENSE) 获得许可