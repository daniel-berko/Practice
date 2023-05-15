using CPG52_Core_Game.Creatures;
using CPG52_Core_Game.Gears;
using CPG52_Core_Game.Items;

namespace CPG52_Core_Game.Players;

public class Computer : Player
{
    public Computer()
    {
        Party foes1 = new Party();
        foes1.AddToParty(new Skeleton(new Dagger()));
        foes1.AddToInventory(new HealingPotion());
        Parties.Add(foes1);

        Party foes2 = new Party();
        foes2.AddToParty(new Skeleton());
        foes2.AddToParty(new Skeleton());
        foes2.AddToInventory(new HealingPotion());
        foes2.AddToInventory(new Dagger());
        foes2.AddToInventory(new Dagger());
        Parties.Add(foes2);

        Party foes3 = new Party();
        foes3.AddToParty(new The_Uncoded_One());
        foes3.AddToInventory(new HealingPotion());
        Parties.Add(foes3);
    }
}