namespace CPG31_The_Fountain_of_Objects;

public abstract class Creature
{
    public Location Position { get; private set; }
    public bool IsAlive { get; set; }

    public Creature(Location position)
    {
        Position = position;
        IsAlive = true;
    }

    public void Move(string action, int times)
    {
        string direction = action.Substring(5);
        {
            for (int i = 0; i < times; i++)
            {
                if (Map.OnGrid(Position, direction))
                {
                    switch (direction)
                    {
                        case "north":
                            Position.SetRow(Position.GetRow() +1);
                            break;
                        case "west":
                            Position.SetColumn(Position.GetColumn() -1);
                            break;
                        case "south":
                            Position.SetRow(Position.GetRow() -1);
                            break;
                        case "east":
                            Position.SetColumn(Position.GetColumn() +1);
                            break;
                    }
                }
                
            }
        }
    }

    public void Die()
    {
        IsAlive = false;
    }
    public abstract void Attack();
    public abstract void Attack(string direction);
}