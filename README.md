# Device Inspector

## Introduction
Device Inspector is a utility tool designed to simplify device-related checks in Unity projects. It provides clear distinctions between editor, simulator, and actual device environments, aiding developers in debugging and testing processes.

## Features
- **Device Environment Detection:** Quickly determines if the application is running on a mobile device, in a simulator, or in the editor.
- **Editor and Simulator Distinction:** Identifies if the Unity Editor is simulating a mobile environment.

## Dependencies
- Unity 2021.1 or newer.

## Compatibility

| Platform      | Supported          | Notes                                   |
|---------------|--------------------|-----------------------------------------|
| iOS           | :white_check_mark: | Fully supported.                        |
| Android       | :white_check_mark: | Fully supported.                        |
| Windows       | :x:                | Not applicable.                         |
| macOS         | :x:                | Not applicable unless in simulator mode.|

## Installation
1. Download the `DeviceInspector` package.
2. Import it into your Unity project via `Assets > Import Package > Custom Package`.

## Usage
To use Device Inspector in your project, you can check the device status by calling:
```csharp
bool isMobile = DeviceInspector.IsMobileDevice();
```
This function returns `true` if the application runs on a mobile device or simulates a mobile environment in the editor.

## API Reference
- `IsMobileDevice()`: Checks if the application is running on a mobile device or in a simulated mobile environment in the editor.
- `IsApplicationEditor()`: Determines if the application is running in the Unity Editor.
- `IsEditorSimulator()`: Checks if the Unity Editor is simulating a mobile device.
- `IsEditorGameView()`: Identifies if the Unity Editor is in game view mode.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.
