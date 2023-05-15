namespace CPG31_The_Fountain_of_Objects.Monsters;

public class Maelstorm : Creature
{
    public Location Position { get; private set; }
    public bool IsAlive { get; set; }

    public Maelstorm(Location position) : base(position)
    {
        Position = position;
        IsAlive = true;
    }
    
    public override void Attack()
    {
        //Throw player
        Map.Player.Move("move north",1);
        Map.Player.Move("move east",2);
        
        //Move Maelstorm
        Move("move south",1);
        Move("move west",2);

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("You have encountered a maelstrom and have been swept away to another room!");
    }
    public override void Attack(string direction) { }
}