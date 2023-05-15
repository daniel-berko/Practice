using CPG52_Core_Game;

public class Item
{
    public string Name { get; protected init; }
    public ItemType Type { get; protected init; }
    public string Description { get; set; }

}

public enum ItemType{HealingPotion}