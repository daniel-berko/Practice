using System.Runtime.CompilerServices;

namespace CPG_24_The_Point;

public class Point
{
    private int xCoordinate { get; } = 0;
    private int yCoordinate { get; } = 0;
    
    public Point(int xCoordinate, int yCoordinate)
    {
        xCoordinate = this.xCoordinate;
        yCoordinate = this.yCoordinate;
    }

    public Point() { }

    public override string ToString()
    {
        return "This point is located at x: " + this.xCoordinate + " and y: " + this.yCoordinate;
    }
}