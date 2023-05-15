namespace CPG31_The_Fountain_of_Objects;

public class Monster
{
    private Location Location { get; set; }
    public MonsterType MonsterType { get; set; }

    public Monster(MonsterType monster, Location location)
    {
        Location = location;
        MonsterType = monster;
    }
}

public enum MonsterType{Maelstorm, Amarok}