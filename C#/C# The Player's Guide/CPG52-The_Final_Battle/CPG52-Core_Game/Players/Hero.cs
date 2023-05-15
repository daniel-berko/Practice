using CPG52_Core_Game.Creatures;
using CPG52_Core_Game.Items;

namespace CPG52_Core_Game.Players;

public class Hero : Player
{
    public Hero()
    {
        Party heroes = new Party();
        heroes.AddToParty(new TOG());
        heroes.AddToParty(new VinFletcher());
        heroes.AddToInventory(new HealingPotion());
        heroes.AddToInventory(new HealingPotion());
        heroes.AddToInventory(new HealingPotion());
        Parties.Add(heroes);
    }
}