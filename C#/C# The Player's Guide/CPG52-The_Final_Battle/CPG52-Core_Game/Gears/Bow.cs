namespace CPG52_Core_Game.Gears;

public class Bow : Gear
{
    public Bow()
    {
        {
            Name = "Bow";
            Damage = ShootArrow();
            Equipped = false;
            AttackType = "Quick Shot";
        }
    }
    public int ShootArrow()
    {
        Random random = new Random();
        int odd = random.Next(1);
        if (odd == 1)
        {
            return 3;
        }
        else
        {
            return 0;
        }
    }
}