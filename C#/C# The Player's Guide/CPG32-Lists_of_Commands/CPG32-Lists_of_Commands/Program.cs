using CPG32_Lists_of_Commands;
using CPG32_Lists_of_Commands.Commands;

Robot mikro = new Robot();

for (int index = 0; index < 3; index++)
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
    mikro.Commands.Add(newCommand);
}


Console.WriteLine();

mikro.Run();