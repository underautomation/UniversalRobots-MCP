# Universal Robots MCP server

A Model Context Protocol (MCP) server for Universal Robots, enabling AI agents and applications to control and monitor UR robots through a standardized interface.

## Overview

This project provides a comprehensive MCP server implementation that exposes Universal Robots functionality through a standardized API. It allows AI assistants, automation tools, and other MCP-compatible clients to interact with UR robots for monitoring, control, and program management.

This is a **modern usage example** of the [UnderAutomation.UniversalRobots](https://www.nuget.org/packages/UnderAutomation.UniversalRobots/) library, demonstrating how to integrate Universal Robots capabilities with the Model Context Protocol framework to create AI-powered robot control solutions.

## Features

### Robot Control

- **Power Management**: Power on/off the robot and control brake release
- **Program Execution**: Play, pause, and stop robot programs
- **Program Management**: Load programs and installations
- **Variable Access**: Get and monitor robot variables

### Dashboard Functions

- **User Interface Control**: Show and close popup messages on the teach pendant
- **Status Monitoring**: Check if robot is in remote control mode, if programs are running
- **System Information**: Retrieve Polyscope version, robot model, and loaded programs

### Real-Time Data Access

Access comprehensive real-time robot data through the Primary Interface:

- **Robot Mode Data**: Current operational mode and status
- **Joint Data**: Individual joint positions, velocities, and currents
- **Cartesian Info**: TCP position and orientation in Cartesian space
- **Tool Data**: Tool communication and mode information
- **Force Mode Data**: Force control parameters when in force mode
- **Safety Data**: Safety system status and parameters
- **Configuration Data**: Robot configuration and kinematics info
- **Program Threads**: Active program execution threads
- **Messages**: Runtime exceptions, popup messages, text messages, and key messages

### File System Access

- **Program Enumeration**: List all available programs on the robot
- **Installation Enumeration**: List all available installations
- SFTP access for file management

## Technology Stack

- **.NET 9.0**: Built on the latest .NET platform
- **ASP.NET Core**: Web application framework for HTTP transport
- **ModelContextProtocol**: MCP server and ASP.NET Core integration (v0.4.0-preview.3)
- **UnderAutomation.UniversalRobots**: Universal Robots SDK (v8.2.0)

## Prerequisites

- .NET 9.0 SDK
- Universal Robots robot (physical or simulator)
- Network connectivity to the robot

## Configuration

The robot connection is configured in [Program.cs](Program.cs):

```csharp
var parameters = new ConnectParameters("192.168.56.101");
parameters.Dashboard.Enable = true;
parameters.Rtde.Enable = false;
parameters.PrimaryInterface.Enable = true;
parameters.Ssh.EnableSftp = true;
parameters.Ssh.Username = "ur"; // use "root" for real robot, "ur" for simulator
parameters.Ssh.Password = "easybot"; // default password
```

Update the IP address and credentials according to your robot setup.

## Usage

1. **Build the project**:

   ```bash
   dotnet build
   ```

2. **Run the MCP server**:

   ```bash
   dotnet run
   ```

3. **Connect your MCP client** to the server endpoint to access all available tools.

## Available MCP Tools

The server exposes over 30 tools including:

- `power_on` / `power_off` - Robot power management
- `play` / `pause` / `stop` - Program execution control
- `load_program` / `load_installation` - Load robot programs and installations
- `show_popup` / `close_popup` - Teach pendant UI control
- `get_robot_model` / `get_polyscope_version` - System information
- `get_joint_data` / `get_cartesian_info` - Real-time position data
- `get_safety_data` / `get_force_mode_data` - Safety and force control status
- `enumerate_programs` / `enumerate_installations` - File system browsing
- And many more for comprehensive robot monitoring and control

## Use Cases

- **AI-Assisted Robot Programming**: Enable AI agents to control and monitor robots
- **Automated Testing**: Integrate robot control into automated test workflows
- **Remote Monitoring**: Access real-time robot data through standardized APIs
- **Multi-Robot Orchestration**: Control multiple robots through a unified interface
- **Educational Applications**: Teach robotics concepts with AI-powered assistance
