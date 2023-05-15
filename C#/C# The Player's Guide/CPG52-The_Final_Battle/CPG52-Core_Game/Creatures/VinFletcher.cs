using CPG52_Core_Game.Gears;

namespace CPG52_Core_Game.Creatures;

public class VinFletcher : Creature
{
    public VinFletcher()
    {
        Name = "Vin Fletcher";
        CreatureType = CreatureType.Vin_Fletcher;
        AttackType = "PUNCH";
        CurrentHp = MaxHp = 15;
        GearEquipped = new Bow();
    }
}