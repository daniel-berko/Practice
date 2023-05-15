namespace CPG52_Core_Game.Creatures;

public class Skeleton : Creature
{
    public Skeleton()
    {
        Name = "SKELETON";
        CreatureType = CreatureType.Skeleton;
        AttackType = "BONE CRUNCH";
        CurrentHp = MaxHp = 5;
    }
    
    public Skeleton(Gear item)
    {
        Name = "SKELETON";
        CreatureType = CreatureType.Skeleton;
        AttackType = "BONE CRUNCH";
        CurrentHp = MaxHp = 5;
        GearEquipped = item;
    }

    protected override int MeleeDamage()
    {
        Random random = new Random();
        int damage = random.Next(0,2);
        
        return damage;
    }
}