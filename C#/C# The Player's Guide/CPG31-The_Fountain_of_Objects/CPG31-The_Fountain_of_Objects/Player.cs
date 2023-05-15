using CPG31_The_Fountain_of_Objects.Monsters;

namespace CPG31_The_Fountain_of_Objects;

public class Player : Creature
{
    public Location Position { get; private set; }
    public bool IsAlive { get; set; }
    public Player(Location position) : base(position)
    {
        Position = position;
        IsAlive = true;
    }

    public void CurrentPosition()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("You are in the room at (Row=" + Position.GetRow() + ", Column=" + Position.GetColumn() + ").");
    }
    
    public void Sense()
    {
        if (Map.NearLocation(Map.Pit.GetPosition(),Position))
        {
            Console.WriteLine("You feel a draft. There is a pit in a nearby room.");
        }
        
        if (Map.SameLocation(Map.Entrance.GetPosition(),Position))
        {
            if (!Map.FountainEnabled)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You see light coming from the cavern entrance.");
            }
        }
        
        if (Map.SameLocation(Map.Fountain.GetPosition(),Position))
        {
            if (Map.FountainEnabled)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
            }
        }
        
        if (Map.NearLocation(Map.Maelstorm.Position, Position))
        {
            Console.WriteLine("You hear the growling and groaning of a maelstrom nearby.");
        }

        if (Map.NearLocation(Map.Amarok.Position, Position))
        {
            Console.WriteLine("You can smell the rotten stench of an amarok in a nearby room.");
        }
    }
    public void Act()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string action = Console.ReadLine()!;
        
        switch (action)
        {
            case "move north":
            case "move west":
            case "move south":
            case "move east":
                Move(action,1);
                break;
            case "shoot north":
            case "shoot west":
            case "shoot south":
            case "shoot east":
                Attack(action);
                break;
            case "enable fountain":
            case "disable fountain":
                OperateFountain(action);
                break;
            case null:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You decided to contemplate your life choices.");
                break;
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You can't do that right now.");
                break;
        }
    }
    public void OperateFountain(string action)
    {
        if (Map.SameLocation(Map.Fountain.Position, Position))
        {
            if ((action == "enable fountain" && Map.FountainEnabled == false)
                ||
                (action == "disable fountain") && Map.FountainEnabled == true)
            {
                Map.FountainEnabled = !Map.FountainEnabled;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You can't do that right now.");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You can't do that right now.");
        }
    }
    public override void Attack() {}
    
    public override void Attack(string direction)
    {
        direction = direction.Substring(6);
        Console.WriteLine(direction);
        Location shot = new Location(Position.GetRow(),Position.GetColumn());
        switch (direction)
        {
            case "north":
                shot.SetRow(shot.GetRow() + 1);
                break;
            case "west":
                shot.SetColumn(shot.GetColumn() - 1);
                break;
            case "south":
                shot.SetRow(shot.GetRow() - 1);
                break;
            case "east":
                shot.SetColumn(shot.GetColumn() + 1);
                break;
        }

        Console.WriteLine("You shot an arrow to the " + direction);
        
        if (Map.SameLocation(shot,Map.Amarok.Position))
        {
            Map.Amarok.Position.SetLocation(-10,-10);
            Console.WriteLine("You hit an Amarok!");
        }

        if (Map.SameLocation(shot, Map.Maelstorm.Position))
        {
            Map.Maelstorm.Position.SetLocation(-10,-10);
            Console.WriteLine("You hit a Maelstorm!");
        }
    }

}