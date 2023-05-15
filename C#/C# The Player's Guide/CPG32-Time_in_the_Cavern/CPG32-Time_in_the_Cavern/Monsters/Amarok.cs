namespace CPG31_The_Fountain_of_Objects.Monsters;

public class Amarok : Creature
{
    public Location Position { get; private set; }
    public bool IsAlive { get; set; }

    public Amarok(Location position) : base(position)
    {
        Position = position;
        IsAlive = true;
    }

    public override void Attack()
    {
        Map.Player.Die();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You have encountered an amarok and died.");
    }

    public override void Attack(string direction) { }
}