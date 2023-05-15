using CPG52_Core_Game.Players;

namespace CPG52_Core_Game;

public class Battle
{
    private List<Party> HeroParties{ get;}
    private List<Party> FoeParties{ get; }
    private Party HeroParty{ get;}
    private Party FoeParty { get; set; }
    private Creature Hero { get; set; }
    private Creature Foe { get; set; }

    public Battle(Player hero, Player opponent)
    {
        HeroParties = hero.Parties;
        FoeParties = opponent.Parties;

        HeroParty = HeroParties.First();
        FoeParty = FoeParties.First();

        Hero = null;
        Foe = null;

    }

    public void Commence(string mode)
    {
        Console.Clear();
        
        // Get each party from the list of foe parties
        foreach (var foeParty in FoeParties.ToList())
        {
            // Set current foe party
            FoeParty = foeParty;
            
            // Get each creature in the party
            foreach (var foe in FoeParty.ReturnMembers().ToList())
            {
                // Set current creatures
                Foe = foe;
                Hero = HeroParty.ReturnMembers()[0];

                while (Hero.CurrentHp > 0 && Foe.CurrentHp > 0)
                {
                    switch (mode)
                    {
                        case "full-auto":
                            Hero.Autopilot = true;
                            Foe.Autopilot = true;
                            BattleStatus(HeroParty.ReturnMembers(), FoeParty.ReturnMembers());
                            Fight(Hero, Foe);
                            break;
                        
                        case "semi-auto":
                            BattleStatus(HeroParty.ReturnMembers(), FoeParty.ReturnMembers());
                            Foe.Autopilot = true;
                            Act(Hero, Foe);
                            break;
                        
                        case "manual":
                            BattleStatus(HeroParty.ReturnMembers(), FoeParty.ReturnMembers());
                            
                            Act(Hero, Foe);

                            // If the opponent is still alive it takes a turn
                            Act(Foe, Hero);
                            break;
                    }
                }
            }
        }
    }

    private void 
        Fight(Creature attacker, Creature defender)
    {
        attacker.Attack(defender);

        switch (defender.CurrentHp)
        {
            // If the opponent's creature is still alive it will also attack
            case > 0 when defender.Autopilot == true:
                defender.Attack(attacker);
                break;
            case 0:
                Console.WriteLine(defender.Name + " has been defeated!");
                HeroParty.AddToInventory(FoeParty.GetInventory());
                FoeParty.ReturnMembers().Remove(defender);
                break;
        }
    }

    private static void BattleStatus(List<Creature> heroParty,List<Creature> foeParty)
    {
        Console.WriteLine("========================= BATTLE =========================");
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (Creature heroUnit in heroParty)
        {
            Console.WriteLine($"{heroUnit.Name} ( {heroUnit.CurrentHp}/{heroUnit.MaxHp} )");
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------------------- VS ---------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        foreach (Creature foeUnit in foeParty)
        {
            Console.WriteLine($"\t \t \t \t \t {foeUnit.Name} ( {foeUnit.CurrentHp}/{foeUnit.MaxHp} )");
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("==========================================================");
    }

    private void Act(Creature actor, Creature opponent)
    {
        switch (actor.ListOptions())
        {
            case "1":
                Fight(actor, opponent);
                break;
            case "2":
            case null:
                actor.DoNothing();
                if (opponent.Autopilot == true)
                {
                    opponent.Attack(actor);
                }
                break;
            case "3":
                HeroParty.UseHealingPotion(actor);
                break;
            case "4":
                Console.WriteLine("Which gear would you like to equip?");
                HeroParty.ListInventory();
                string selected = Console.ReadLine();
                HeroParty.EquipGear(HeroParty.GetGearFromInventory(selected), actor);
                break;
        }
    }
}