namespace CPG52_Core_Game.Items;

public class HealingPotion : Item
{
    public HealingPotion()
    {
        Name = "Healing Potion";
        Type = ItemType.HealingPotion;
        Description = "Heals 10 HP to target";
    }
}