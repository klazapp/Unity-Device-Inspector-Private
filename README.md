# Device Inspector for Unity

## Introduction

The Device Inspector utility, developed under the `com.Klazapp.Utility` namespace, provides essential tools to determine the running environment of a Unity application. It identifies whether the application is executing on a mobile device, within the Unity Editor, or in a simulator environment, enhancing the development and testing processes by adapting functionality dynamically based on the environment.

## Features

- **Environment Detection:** Easily detect if your application is running on a mobile device, in the Unity Editor, or in a device simulator.
- **Editor-specific Checks:** Offers methods to differentiate between game view and simulator view within the Unity Editor, facilitating targeted debugging and feature implementation.
- **Cross-platform Utility:** Useful across various platforms, simplifying the process of writing platform-specific code.

## Dependencies

- **Unity Editor:** Utilizes Unity Editor scripts to check and manage editor-specific states and environments.

## Compatibility

This package does not rely on specific Unity rendering pipelines or versions and is primarily aimed at improving editor functionality and cross-platform development.

| Compatibility | URP | BRP | HDRP |
|---------------|-----|-----|------|
| Compatible    | Yes | Yes | Yes  |

## Installation

To install the Device Inspector package:

1. Clone the repository or download the latest release.
2. Import the `DeviceInspector.cs` script into your Unity project, ideally within an `Editor` folder to segregate editor-only scripts from runtime code.

## Usage

The `DeviceInspector` class can be used to programmatically determine the running environment of your Unity application, which helps in implementing platform-specific functionalities or debugging. Here are some examples of how to use the class:

### Check if Running on a Mobile Device

Determine if the application is running on a mobile device or an emulator/simulator within the Unity Editor:

```csharp
bool isMobile = DeviceInspector.IsMobileDevice();
Debug.Log("Is this a mobile device or simulator? " + isMobile);
```

### Differentiate Between Editor Game View and Simulator

Check if the Unity Editor is currently in game view or simulating a mobile device:

```csharp
bool isSimulator = DeviceInspector.IsEditorSimulator();
bool isGameView = DeviceInspector.IsEditorGameView();

Debug.Log("Is this running in the simulator? " + isSimulator);
Debug.Log("Is this running in the game view? " + isGameView);
```

These checks are especially useful when you need to debug or alter behavior based on whether the application is running directly on a physical device, a simulator, or within the Unity Editor's game view. This functionality can be integrated to adjust UI elements, optimize performance, or apply platform-specific settings dynamically.

## To-Do List (Future Features)

- [ ] Expand device type detection to include additional platforms and environments.
- [ ] Provide a GUI within the Unity Editor to toggle and visualize environment settings directly.
- [ ] Integrate more detailed device-specific features and checks.

## License

This package is available under the MIT License, allowing you to use and modify the tool as needed for both personal and commercial projects.
