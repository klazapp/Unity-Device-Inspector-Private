# Klazapp Device Inspector

The Klazapp Device Inspector is a simple Unity utility that allows developers to programmatically check if their application is running on a mobile device, within the Unity Editor, or a simulated mobile environment in the editor. This utility helps in implementing platform-specific logic seamlessly.

## Features

- **Environment Detection**: Identify whether your application is running on a real device, in the Unity Editor, or a simulated environment within the editor.
- **Mobile Simulation**: Detect if the editor simulates a mobile device for accurate testing and debugging.
- **Simple Integration**: Easy to integrate and use within any Unity project to enhance debugging and development workflows.

## Dependencies

- Unity 2021.3 LTS or newer for enhanced simulator checks.

## Installation

1. Clone or download the Device Inspector package from its repository.
2. Import the package into your Unity project under the `Assets` directory.
3. The tool is now ready to use within your scripts.

## Usage

### Checking Device Type

To determine if your application is running on a mobile device or a simulator in the editor, you can use the following method:

```csharp
bool isMobile = DeviceInspector.IsMobileDevice();
```

This method returns `true` if the application runs on a mobile device or is simulated as a mobile device in the Unity Editor. It returns `false` if the application is running in the editor in a non-simulated (desktop) mode.

### Advanced Checks

- **Check if Running in Editor**:
  ```csharp
  bool inEditor = DeviceInspector.IsApplicationEditor();
  ```

- **Determine if Running in Simulator**:
  ```csharp
  bool inSimulator = DeviceInspector.IsEditorSimulator();
  ```

- **Check if Running in Game View (as Desktop)**:
  ```csharp
  bool inGameView = DeviceInspector.IsEditorGameView();
  ```

These methods provide more granular control over the runtime environment, allowing for more precise debugging and feature toggling based on the environment.

## Customization

Modify the `DeviceInspector` class to add more specific checks as required by your development process or to handle additional environments like VR or specific consoles.

## Known Issues

- Simulator detection relies on Unity's device type detection which might not always align with actual hardware specifications, especially in custom or complex editor setups.

## To-Do List

- Extend support for additional Unity versions and other development environments.
- Provide options for logging and detailed environment reports.
- Improve the detection mechanisms for edge cases and newer Unity features like Device Simulator.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
