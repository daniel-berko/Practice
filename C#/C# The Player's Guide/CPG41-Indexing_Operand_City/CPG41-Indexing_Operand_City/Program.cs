BlockCoordinate coordinate = new BlockCoordinate(4, 3);

Console.WriteLine(coordinate[0]);
Console.WriteLine(coordinate[1]);

public enum Direction { North, East, South, West }

public record BlockOffset(int RowOffset, int ColumnOffset);

public record BlockCoordinate(int Row, int Column)
{
    public int this[int index] => index switch { 0 => Row, 1 => Column };
}