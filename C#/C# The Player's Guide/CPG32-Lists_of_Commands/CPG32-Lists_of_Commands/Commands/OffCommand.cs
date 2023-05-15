namespace CPG32_Lists_of_Commands.Commands;

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}