# API Manager

[简体中文](/README_CN.md) | [English](/README.md)

This project is the official core management plugin for [SharwAPI](https://github.com/sharwapi/sharwapi.Core).

Its primary responsibility is to serve as the backend API for the management console, allowing administrators to view the status of currently loaded plugins and uniformly aggregate and mount the management endpoints of all plugins.

## Features

- **Plugin Retrieval**: Dynamically retrieve information (name, version, display name) of all plugins loaded in the current API instance.
- **Route Aggregation**: Automatically traverses all plugins and mounts their defined management endpoints under the `/admin/plugin/{pluginName}/` path, providing a unified entry point for management interfaces.

## Installation & Usage

1. Download the compiled `.dll` file from [Releases](https://github.com/sharwapi/sharwapi.plugin.apimgr/releases).
2. Place it into the `Plugins` directory of the Core API.
3. Restart the API.

## License

This project is licensed under the [GNU Lesser General Public License v3.0](/LICENSE).