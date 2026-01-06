

using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Rtde;

internal class Program
{
    public static UR _robot = new UR();
    private static void Main(string[] args)
    {
        var parameters = new ConnectParameters("192.168.56.101");
        parameters.Dashboard.Enable = true;
        parameters.PrimaryInterface.Enable = true;
        parameters.Ssh.EnableSftp = true;
        parameters.Ssh.Username = "ur"; // use "root" for a real robot and "ur" for simulator
        parameters.Ssh.Password = "easybot"; // default password is "easybot"

        parameters.Rtde.Enable = true;
        for (int i = 64; i <= 127; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.InputBitRegisters, i);
        for (int i = 64; i <= 127; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.OutputBitRegisters, i);
        for (int i = 0; i <= 47; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.InputIntRegisters, i);
        for (int i = 0; i <= 47; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.OutputIntRegisters, i);
        for (int i = 0; i <= 47; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.InputDoubleRegisters, i);
        for (int i = 0; i <= 47; i++) parameters.Rtde.OutputSetup.Add(RtdeOutputData.OutputDoubleRegisters, i);

        _robot.Connect(parameters);

        var builder = WebApplication.CreateBuilder(args);
        // Register MCP server and discover tools from the current assembly
        builder.Services.AddMcpServer().WithHttpTransport().WithToolsFromAssembly();
        var app = builder.Build();
        // Add MCP middleware
        app.MapMcp();
        app.Run();
    }
}