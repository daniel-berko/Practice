namespace CPG52_Core_Game;

public class Creature
{
    protected CreatureType CreatureType { get; set; }
    protected string AttackType { get; init; } = "KICK";
    public string Name { get; protected set; } = "";
    public int MaxHp { get; protected init; }
    public int CurrentHp { get; set; }
    protected Gear GearEquipped { get; set; } = null;
    public bool Autopilot { get; set; } = false;

    protected Creature(Gear item)
    {
        GearEquipped = item;
    }

    protected Creature() { }

    public void DoNothing()
    {
        Console.WriteLine(Name + " did NOTHING.");
    }
    
    public void Rename(string name)
    {
        Name = name;
    }
    
    public string ListOptions()
    {
        Console.WriteLine("It is " + Name + "'s turn...");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Standard Attack (" + DamageType() + ")");
        Console.WriteLine("2 - Do Nothing");
        Console.WriteLine("3 - Use Health Potion");
        Console.WriteLine("4 - Equip Gear");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("What do you want to do? ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string choice = Console.ReadLine() ?? throw new Exception("Please make a valid choice.");
        Console.ForegroundColor = ConsoleColor.Gray;
        
        return choice;
    }
    
    public void Attack(Creature target)
    {
            Console.WriteLine(Name + " used " + DamageType() + " on " + target.Name + ".");
            target.TakeDamage(Damage());
            Console.WriteLine(DamageType() + " dealt " + Damage() + " damage to " + target.Name + ".");
            Console.WriteLine(target.Name + " is now at " + target.CurrentHp + "/" + target.MaxHp + "HP.");
            Console.WriteLine();
    }

    protected virtual int MeleeDamage()
    {
        return 1;
    }

    private int GearDamage()
    {
        return GearEquipped != null ? GearEquipped.Damage : 0;
    }

    private int Damage()
    {
        return Math.Max(GearDamage(), MeleeDamage());
    }

    private string DamageType()
    {
        return GearEquipped != null ? GearEquipped.AttackType : AttackType;
    }

    private void TakeDamage(int damage)
    {
        if (CurrentHp - damage < 0)
        {
            CurrentHp = 0;
        }
        else
        {
            CurrentHp -= damage;
        }
    }

    public void Heal(int health = 10)
    {
        if (CurrentHp + health > MaxHp)
        {
            CurrentHp = MaxHp;
        }
        else
        {
            CurrentHp += health;
        }
    }

    public void EquipGear(Gear item)
    {
        GearEquipped = item;
    }
}

public enum CreatureType {Skeleton, TOG, TUO, Vin_Fletcher}