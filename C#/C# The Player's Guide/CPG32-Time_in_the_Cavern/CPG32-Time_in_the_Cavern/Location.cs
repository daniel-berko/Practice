namespace CPG31_The_Fountain_of_Objects;

public class Location
{
    private int Row { get; set; }
    private int Column { get; set; }

    public Location(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int GetRow()
    {
        return Row;
    }

    public int GetColumn()
    {
        return Column;
    }
    public void SetRow(int newRow)
    {
        Row = newRow;
    }

    public void SetColumn(int newColumn)
    {
        Column = newColumn;
    }

    public void SetLocation(int row, int column)
    {
        Row = row;
        Column = column;
    }
    
}