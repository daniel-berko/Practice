namespace CPG52_Core_Game.Creatures;

public class The_Uncoded_One : Creature
{
    public The_Uncoded_One()
    {
        Name = "THE UNCODED ONE";
        CreatureType = CreatureType.TUO;
        AttackType = "UNRAVELING ATTACK";
        CurrentHp = MaxHp = 15;
    }

    protected override int MeleeDamage()
    {
        Random random = new Random();
        int damage = random.Next(0, 3);

        return damage;
    }
}