using CPG52_Core_Game.Gears;

namespace CPG52_Core_Game.Creatures;

public class TOG : Creature
{
    public TOG()
    {
        Name = "TOG";
        CreatureType = CreatureType.TOG;
        AttackType = "PUNCH";
        CurrentHp = MaxHp = 25;
        GearEquipped = new Sword();
    }
}
