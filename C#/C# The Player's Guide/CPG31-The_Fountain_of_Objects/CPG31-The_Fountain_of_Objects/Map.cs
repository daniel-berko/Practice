using CPG31_The_Fountain_of_Objects.Monsters;

namespace CPG31_The_Fountain_of_Objects;

public class Map
{
    private static int Row { get; set; }
    private static int Column { get; set; }
    public static Player Player { get; private set; } = null!;
    public static Room Entrance { get; private set; } = null!;
    public static Room Fountain { get; private set; } = null!;
    public static Room Pit { get; private set; } = null!;
    public static Maelstorm Maelstorm { get; private set; } = null!;
    public static Maelstorm Maelstorm2 { get; set; } = null!;
    public static Amarok Amarok { get; private set; } = null!;
    public static bool FountainEnabled { get; set; }

    public Map(string size)
    {
        switch (size)
        {
            case "small":
                Row = 4;
                Column = 4;
                Player = new Player(new Location(0,0));
                Fountain = new Room(Type.Fountain, new Location(0, 2));
                Entrance = new Room(Type.Entrance, new Location(0, 0));
                Pit = new Room(Type.Pit, new Location(4, 4));
                Maelstorm = new Maelstorm(new Location(0, 4));
                Amarok = new Amarok(new Location(4, 0));
                break;
            case "medium":
                Row = 6;
                Column = 6;
                Player = new Player(new Location(0, 0));
                Fountain = new Room(Type.Fountain, new Location(2, 4));
                Entrance = new Room(Type.Entrance, new Location(0, 0));
                Maelstorm = new Maelstorm(new Location(5, 5));
                Amarok = new Amarok(new Location(4, 0));
                Pit = new Room(Type.Pit, new Location(4, 4));
                break;
            case "large":
                Row = 8;
                Column = 8;
                Player = new Player(new Location(0,0));
                Fountain = new Room(Type.Fountain, new Location(4, 6));
                Entrance = new Room(Type.Entrance, new Location(0, 0));
                Maelstorm = new Maelstorm(new Location(5,5));
                Maelstorm2 = new Maelstorm(new Location(7,7));
                Amarok = new Amarok(new Location(4, 0));
                Pit = new Room(Type.Pit, new Location(0, 6));
                break;
            case null:
            default:
                Row = 4;
                Column = 4;
                Player = new Player(new Location(0,0));
                Fountain = new Room(Type.Fountain, new Location(0, 2));
                Entrance = new Room(Type.Entrance, new Location(0, 0));
                break;
        }

        FountainEnabled = false;
    }
    
    public static bool SameLocation(Location location1, Location location2)
    {
        if ((location1.GetColumn() == location2.GetColumn())
            && location1.GetRow() == location2.GetRow())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool NearLocation(Location location1, Location location2)
    {
        if (location1.GetRow() == location2.GetRow() && location1.GetColumn() == location2.GetColumn()) return true;
        if (location1.GetRow() - 1 == location2.GetRow() && location1.GetColumn() == location2.GetColumn()) return true;
        if (location1.GetRow() == location2.GetRow() && location1.GetColumn() - 1 == location2.GetColumn()) return true;
        if (location1.GetRow() - 1 == location2.GetRow() &&
            location1.GetColumn() - 1 == location2.GetColumn()) return true;
        if (location1.GetRow() + 1 == location2.GetRow() && location1.GetColumn() == location2.GetColumn()) return true;
        if (location1.GetRow() == location2.GetRow() && location1.GetColumn() + 1 == location2.GetColumn()) return true;
        if (location1.GetRow() + 1 == location2.GetRow() &&
            location1.GetColumn() + 1 == location2.GetColumn()) return true;
        if (location1.GetRow() + 1 == location2.GetRow() &&
            location1.GetColumn() - 1 == location2.GetColumn()) return true;
        if (location1.GetRow() - 1 == location2.GetRow() &&
            location1.GetColumn() + 1 == location2.GetColumn()) return true;
        return false;
    }
    
    public static bool OnGrid(Location location, string direction)
    {
        switch (direction)
        {
            case "north":
                if (location.GetRow() + 1 <= Row) return true;
                break;
            case "west":
                if (location.GetColumn() - 1 >= 0) return true;
                break;
            case "south":
                if (location.GetRow() - 1 >= 0) return true;
                break;
            case "east":
                if (location.GetColumn() + 1 <= Column) return true;
                break;
        }
        return false;
    }
    
}