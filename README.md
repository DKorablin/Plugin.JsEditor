# JavaScript Editor Plugin
[![Auto build](https://github.com/DKorablin/Plugin.JsEditor/actions/workflows/release.yml/badge.svg)](https://github.com/DKorablin/Plugin.JsEditor/releases/latest)
[![NuGet](https://img.shields.io/nuget/v/AlphaOmega.SAL.Plugin.JsEditor)](https://www.nuget.org/packages/AlphaOmega.SAL.Plugin.JsEditor)

A [SAL](https://github.com/DKorablin/SAL.Windows) plugin that provides an interactive JavaScript editor with syntax highlighting, external file references, and a choice of JavaScript engine.

## Features

- Syntax-highlighted JavaScript editor powered by [FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox)
- Run JavaScript directly inside the host application
- Load external `.js` files as references before execution
- Runtime error panel with location info; double-click an error to jump to the offending line
- Switchable JavaScript engine — choose between [JINT](#engines) (default) and [MSScriptControl](#engines)

## Engines

| Engine | Description | Constraint |
|---|---|---|
| **Jint** *(default)* | Pure .NET JavaScript interpreter ([Jint](https://github.com/sebastienros/jint)) | Works on both .NET Framework 4.8 and .NET 8 |
| **MSScriptControl** | COM-based Windows JScript engine | x86 process only; requires Windows |

The active engine is configured via the plugin settings (`Tools → Compilers → JavaScript Editor`).

## Requirements

- Windows OS
- SAL host application
- .NET Framework 4.8 **or** .NET 8.0 (Windows)

## Installation

1. Download the release archive (.zip or .nupkg).
2. Place the plugin assembly into the host application plugin directory (SAL / host supporting Windows environment):
	- [Flatbed.Dialog](https://dkorablin.github.io/Flatbed-Dialog/)
	- [Flatbed.Dialog (Lite)](https://dkorablin.github.io/Flatbed-Dialog-Lite)
	- [Flatbed.MDI](https://dkorablin.github.io/Flatbed-MDI)
	- [Flatbed.MDI (WPF)](https://dkorablin.github.io/Flatbed-MDI-Avalon)
	- [Flatbed.MDI (AvaloniaUI)](https://dkorablin.github.io/Flatbed-MDI-AvaloniaUI)
3. Restart the host application; Plugin.JsEditor should appear in the plugin list (Tools -> Compilers -> JsEditor).

## Settings

| Setting | Values | Default | Description |
|---|---|---|---|
| `Interpreter Type` | `Jint`, `MsScript` | `Jint` | JavaScript engine used to execute scripts |

## License

[MIT](https://opensource.org/licenses/MIT)