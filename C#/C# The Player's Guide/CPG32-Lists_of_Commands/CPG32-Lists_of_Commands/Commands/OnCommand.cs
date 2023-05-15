namespace CPG32_Lists_of_Commands.Commands;

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}