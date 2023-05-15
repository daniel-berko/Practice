namespace CPG_25;

public class InventoryItem
{
    public string Name { get; }
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(string name, double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}