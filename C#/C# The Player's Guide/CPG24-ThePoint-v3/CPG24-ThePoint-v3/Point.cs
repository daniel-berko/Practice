namespace CPG24_ThePoint_v3;

public class Point
{
    private int X { get;}
    private int Y { get;}
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public override string ToString()
    {
        return "This point is located at x: " + X + " and y: " + Y;
    }
}