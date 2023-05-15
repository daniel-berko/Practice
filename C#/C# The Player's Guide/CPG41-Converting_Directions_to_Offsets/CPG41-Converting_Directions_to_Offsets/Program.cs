Direction direction = Direction.South;
Console.WriteLine(direction);
Console.WriteLine((BlockOffset)direction);

public enum Direction { North, East, South, West }

public record BlockOffset(int RowOffset, int ColumnOffset)
{
    public static implicit operator BlockOffset(Direction direction)
    {
        return direction switch
        {
            Direction.North => new BlockOffset(-1, 0),
            Direction.South => new BlockOffset(+1, 0),
            Direction.West => new BlockOffset(0, -1),
            Direction.East => new BlockOffset(0, +1)
        };
    }
}

public record BlockCoordinate(int Row, int Column);