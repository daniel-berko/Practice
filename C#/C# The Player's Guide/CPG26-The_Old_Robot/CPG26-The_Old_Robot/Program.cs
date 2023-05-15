// See https://aka.ms/new-console-template for more information

using CPG26_The_Old_Robot;
using CPG26_The_Old_Robot.Commands;

Robot microbi = new Robot();

for (int index = 0; index < microbi.Commands.Length; index++)
{
    string? input = Console.ReadLine();
    RobotCommand newCommand = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
    };
    microbi.Commands[index] = newCommand;
}

Console.WriteLine();

microbi.Run();