using System.Collections;
using CPG52_Core_Game.Items;
using CPG52_Core_Game.Players;

namespace CPG52_Core_Game;

public class Party : IEnumerable
{
    private List<Creature> Members = new List<Creature>();
    private List<Item> Inventory = new List<Item>();

    public void AddToParty(Creature creature)
    {
        Members.Add(creature);
    }
    
    public void AddToInventory(params Item[] items)
    {
        foreach (var item in items)
        {
            Inventory.Add(item);
        }
    }

    public void AddToInventory(List<Item> items)
    {
        Inventory.AddRange(items);
    }

    public List<Item> GetInventory()
    {
        return Inventory;
    }

    public void ListInventory()
    {
        foreach (var item in Inventory)
        {
            Console.WriteLine(item.Name);
        }
    }

    public Gear GetGearFromInventory(string name)
    {
        return (Gear)Inventory.Find(g => g.Name == name) ?? throw new Exception("Gear can't be found.");
    }

    public void EquipGear(Gear item, Creature creature)
    {
        if (Inventory.Contains(item))
        {
            Inventory.Remove(item);
            creature.EquipGear(item);
            Console.WriteLine($"{creature.Name} equipped a(n) {item.Name}");
        }
        else
        {
            Console.WriteLine($"You don't have any {item.Name} available!");
        }
    }

    public List<Creature> ReturnMembers()
    {
        return Members;
    }
    
    public void UseHealingPotion(Creature target)
    {
        if (Inventory.Count > 0)
        {
            Item healthPotion = Inventory.First(p => p.Type == ItemType.HealingPotion);

            if (target.CurrentHp + 10 > target.MaxHp)
            {
                target.CurrentHp = target.MaxHp;
            }
            else
            {
                target.CurrentHp += 10;
            }

            Inventory.Remove(healthPotion);
            Console.WriteLine(
                $"You used a healing potion on {target.Name}, current health {target.CurrentHp}/{target.MaxHp}");
        }
        else
        {
            Console.WriteLine("You're out of healing potions!");
        }

    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }


    public Hero this[int i]
    {
        get { throw new NotImplementedException(); }
    }
}

