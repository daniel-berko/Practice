using System.ComponentModel.DataAnnotations.Schema;

namespace CPG31_The_Fountain_of_Objects;

public class Room
{
    public static Type Type { get; set; }
    public Location Position { get; set; }

    public Room(Type type, Location position)
    {
        Type = type;
        Position = position;
    }

    public Location GetPosition()
    {
        return Position;
    }
}

public enum Type
{
    Entrance,
    Fountain,
    Pit,
    Empty
}