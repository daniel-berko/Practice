namespace CPG52_Core_Game;

public class Gear : Item
{
    public string Name { get; protected init; }
    public bool Equipped { get; set; }
    public int Damage { get; protected init; }
    public string AttackType { get; protected init; } = "Slash";
}