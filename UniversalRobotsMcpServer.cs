using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Globalization;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.PrimaryInterface;
using UnderAutomation.UniversalRobots.PrimaryInterface.Internal;
using UnderAutomation.UniversalRobots.Rtde;


[McpServerToolType]
public sealed class UniversalRobotsMcpServer
{
    public UniversalRobotsMcpServer()
    {
    }

    [McpServerTool, Description("Power on the robot and release brakes")]
    public static void PowerOn()
    {
        Program._robot.Dashboard.PowerOn();
        Program._robot.Dashboard.ReleaseBrake();
    }

    [McpServerTool, Description("Power off the robot")]
    public static void PowerOff()
    {
        Program._robot.Dashboard.PowerOff();
    }


    [McpServerTool, Description("Get the name of the currently loaded program")]
    public static string GetLoadedProgram()
    {
        var result = Program._robot.Dashboard.GetLoadedProgram();
        return result.Value;
    }


    [McpServerTool, Description("Check if the robot is in remote control mode")]
    public static bool IsInRemoteControl()
    {
        var result = Program._robot.Dashboard.IsInRemoteControl();
        return result.Value;
    }

    [McpServerTool, Description("Check if the robot is in remote control mode")]
    public static string GetPolyscopeVersion()
    {
        var result = Program._robot.Dashboard.GetPolyscopeVersion();
        return result.Value.Description;
    }

    [McpServerTool, Description("Get the robot model")]
    public static string GetRobotModel()
    {
        var result = Program._robot.Dashboard.GetRobotModel();
        return result.Value.ToString(); ;
    }

    [McpServerTool, Description("Get a variable value from the robot")]
    public static GlobalVariable GetVariable(string name)
    {
        var result = Program._robot.Dashboard.GetVariable(name);
        return result.Value;
    }


    [McpServerTool, Description("Check if a program is running on the robot")]
    public static bool IsProgramRunning()
    {
        var result = Program._robot.Dashboard.IsProgramRunning();
        return result.Value;
    }



    [McpServerTool, Description("Load an installation")]
    public static void LoadInstallation(string name)
    {
        Program._robot.Dashboard.LoadInstallation(name);
    }

    [McpServerTool, Description("Load a program")]
    public static void LoadProgram(string name)
    {
        Program._robot.Dashboard.LoadProgram(name);
    }

    [McpServerTool, Description("Pause the robot program")]
    public static void Pause()
    {
        Program._robot.Dashboard.Pause();
    }

    [McpServerTool, Description("Stop the robot program")]
    public static void Stop()
    {
        Program._robot.Dashboard.Stop();
    }


    [McpServerTool, Description("Start the robot program")]
    public static void Play()
    {
        Program._robot.Dashboard.Play();
    }


    [McpServerTool, Description("Show a popup message on the robot teach pendant")]
    public static void ShowPopup(string message)
    {
        Program._robot.Dashboard.ShowPopup(message);
    }


    [McpServerTool, Description("Close any popup message on the robot teach pendant")]
    public static void ClosePopup()
    {
        Program._robot.Dashboard.ClosePopup();
        Program._robot.Dashboard.CloseSafetyPopup();
    }

    [McpServerTool, Description("Enumerate programs on the robot")]
    public static string[] EnumeratePrograms()
    {
        return Program._robot.Sftp.EnumeratePrograms();
    }


    [McpServerTool, Description("Enumerate installations on the robot")]
    public static string[] EnumerateInstallations()
    {
        return Program._robot.Sftp.EnumerateInstallations();
    }



    [McpServerTool, Description("Enumerate installations on the robot")]
    public static PrimaryInterfaceClientBase GetPrimaryInterfaceMessages()
    {
        return Program._robot.PrimaryInterface;
    }


    [McpServerTool, Description("Get the current robot mode data")]
    public static RobotModeDataPackageEventArgs GetRobotModeData()
    {
        return Program._robot.PrimaryInterface.RobotModeData;
    }
    [McpServerTool, Description("Get the current masterboard data")]
    public static MasterboardDataPackageEventArgs GetMasterboardData()
    {
        return Program._robot.PrimaryInterface.MasterboardData;
    }

    [McpServerTool, Description("Get the current joint data")]
    public static JointDataPackageEventArgs GetJointData()
    {
        return Program._robot.PrimaryInterface.JointData;
    }

    [McpServerTool, Description("Get the current tool data")]
    public static ToolDataPackageEventArgs GetToolData()
    {
        return Program._robot.PrimaryInterface.ToolData;
    }

    [McpServerTool, Description("Get the current cartesian info")]
    public static CartesianInfoPackageEventArgs GetCartesianInfo()
    {
        return Program._robot.PrimaryInterface.CartesianInfo;
    }

    [McpServerTool, Description("Get the current kinematics info")]
    public static KinematicsInfoPackageEventArgs GetKinematicsInfo()
    {
        return Program._robot.PrimaryInterface.KinematicsInfo;
    }

    [McpServerTool, Description("Get the current configuration data")]
    public static ConfigurationDataPackageEventArgs GetConfigurationData()
    {
        return Program._robot.PrimaryInterface.ConfigurationData;
    }

    [McpServerTool, Description("Get the current force mode data")]
    public static ForceModeDataPackageEventArgs GetForceModeData()
    {
        return Program._robot.PrimaryInterface.ForceModeData;
    }

    [McpServerTool, Description("Get the current additional info")]
    public static AdditionalInfoPackageEventArgs GetAdditionalInfo()
    {
        return Program._robot.PrimaryInterface.AdditionalInfo;
    }

    [McpServerTool, Description("Get the current calibration data")]
    public static CalibrationDataPackageEventArgs GetCalibrationData()
    {
        return Program._robot.PrimaryInterface.CalibrationData;
    }

    [McpServerTool, Description("Get the current safety data")]
    public static SafetyDataPackageEventArgs GetSafetyData()
    {
        return Program._robot.PrimaryInterface.SafetyData;
    }

    [McpServerTool, Description("Get the current tool communication info")]
    public static ToolCommunicationInfoPackageEventArgs GetToolCommunicationInfo()
    {
        return Program._robot.PrimaryInterface.ToolCommunicationInfo;
    }

    [McpServerTool, Description("Get the current tool mode info")]
    public static ToolModeInfoPackageEventArgs GetToolModeInfo()
    {
        return Program._robot.PrimaryInterface.ToolModeInfo;
    }

    [McpServerTool, Description("Get the current singularity info")]
    public static SingularityInfoPackageEventArgs GetSingularityInfo()
    {
        return Program._robot.PrimaryInterface.SingularityInfo;
    }

    [McpServerTool, Description("Get the current program threads")]
    public static ProgramThreadsEventArgs GetProgramThreads()
    {
        return Program._robot.PrimaryInterface.ProgramThreads;
    }

    [McpServerTool, Description("Get the current version")]
    public static VersionEventArgs GetVersion()
    {
        return Program._robot.PrimaryInterface.Version;
    }

    [McpServerTool, Description("Get the current key message")]
    public static KeyMessageEventArgs GetKeyMessage()
    {
        return Program._robot.PrimaryInterface.KeyMessage;
    }

    [McpServerTool, Description("Get the current popup message")]
    public static PopupMessageEventArgs GetPopupMessage()
    {
        return Program._robot.PrimaryInterface.PopupMessage;
    }

    [McpServerTool, Description("Get the current text message")]
    public static TextMessageEventArgs GetTextMessage()
    {
        return Program._robot.PrimaryInterface.TextMessage;
    }

    [McpServerTool, Description("Get the current runtime exception message")]
    public static RuntimeExceptionMessageEventArgs GetRuntimeExceptionMessage()
    {
        return Program._robot.PrimaryInterface.RuntimeExceptionMessage;
    }


    [McpServerTool, Description("Get all global variables from the robot")]
    public static GlobalVariable[] GetGlobalVariables()
    {
        return Program._robot.PrimaryInterface.GlobalVariables.GetAll();
    }



    [McpServerTool, Description("Move the robot to specified joint positions in radians. 6 elements array: base, shoulder, elbow, wrist1, wrist2, wrist3.")]
    public static void MoveRobotJoints(double[] jointsRadians)
    {
        if (jointsRadians.Length != 6)
            throw new ArgumentException("jointsRadians must have exactly 6 elements.");
        Program._robot.PrimaryInterface.Script.Send($"movej([{string.Join(", ", jointsRadians.Select(j => j.ToString(CultureInfo.InvariantCulture)))}], a=1, v=1)");
    }


    [McpServerTool, Description("Get the input bit registers from the robot")]
    public static RtdeBitRegistersValue GetInputBitRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.InputBitRegisters;
    }
    [McpServerTool, Description("Get the output bit registers from the robot")]
    public static RtdeBitRegistersValue GetOutputBitRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.OutputBitRegisters;
    }


    [McpServerTool, Description("Get the input Int registers from the robot")]
    public static RtdeIntRegistersValue GetInputIntRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.InputIntRegisters;
    }
    [McpServerTool, Description("Get the output Int registers from the robot")]
    public static RtdeIntRegistersValue GetOutputIntRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.OutputIntRegisters;
    }


    [McpServerTool, Description("Get the input Double registers from the robot")]
    public static RtdeDoubleRegistersValue GetInputDoubleRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.InputDoubleRegisters;
    }
    [McpServerTool, Description("Get the output Double registers from the robot")]
    public static RtdeDoubleRegistersValue GetOutputDoubleRegisters()
    {
        return Program._robot.Rtde.OutputDataValues.OutputDoubleRegisters;
    }

    [McpServerTool, Description("Set an output bit register on the robot")]
    public static void SetOutputBitRegister(int id, bool value)
    {
        Program._robot.PrimaryInterface.Script.Send($@"
sec secondaryProgram():
  write_output_boolean_register({id}, {(value ? "True" : "False")})
end
");
    }

    [McpServerTool, Description("Set an output int register on the robot")]
    public static void SetOutputIntRegister(int id, int value)
    {
        Program._robot.PrimaryInterface.Script.Send($@"
sec secondaryProgram():
  write_output_integer_register({id}, {value})
end
");
    }

    [McpServerTool, Description("Set an output double register on the robot")]
    public static void SetOutputDoubleRegister(int id, double value)
    {
        Program._robot.PrimaryInterface.Script.Send($@"
sec secondaryProgram():
  write_output_float_register({id}, {value.ToString(CultureInfo.InvariantCulture)})
end
");
    }

}
