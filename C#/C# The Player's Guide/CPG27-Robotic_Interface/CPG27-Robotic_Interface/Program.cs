// See https://aka.ms/new-console-template for more information
using CPG27_Robotic_Interface.Commands;

Robot microbi = new Robot();

for (int index = 0; index < microbi.Commands.Length; index++)
{
    string? input = Console.ReadLine();
    IRobotCommand newCommand = input switch
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