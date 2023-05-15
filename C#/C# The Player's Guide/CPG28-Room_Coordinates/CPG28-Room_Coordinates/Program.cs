// See https://aka.ms/new-console-template for more information

Coordinate a = new Coordinate(3, 3);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(2, 2);

Console.WriteLine(Coordinate.NextToCheck(a, b));
Console.WriteLine(Coordinate.NextToCheck(b, c));
Console.WriteLine(Coordinate.NextToCheck(a, c));

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool NextToCheck(Coordinate one, Coordinate two)
    {
        int rowDifference = one.Row - two.Row;
        int columnDifference = one.Column - two.Column;
        
        if (Math.Abs(rowDifference) <= 1 && columnDifference == 0) return true;
        if (Math.Abs(columnDifference) <= 1 && rowDifference == 0) return true;

        return false;
    }
}