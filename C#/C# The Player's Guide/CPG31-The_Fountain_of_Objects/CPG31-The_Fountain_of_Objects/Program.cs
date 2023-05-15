// See https://aka.ms/new-console-template for more information

using CPG31_The_Fountain_of_Objects;
using CPG31_The_Fountain_of_Objects.Monsters;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("What size map would you like to play on? Your options are: small, medium, large.");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string size = Console.ReadLine();
    if (size is "small" or "medium" or "large")
    {
        Map map = new Map(size);
        
        while (true)
        {
            Map.Player.CurrentPosition();
            Map.Player.Sense();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("What would you like to do? ");
            Map.Player.Act();

            if (Map.SameLocation(Map.Pit.Position, Map.Player.Position))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You have fallen into a pit and died.");
                return;
            }
            if (Map.SameLocation(Map.Amarok.Position, Map.Player.Position))
            {
                Map.Amarok.Attack();
                return;
            }
            if (Map.SameLocation(Map.Maelstorm.Position, Map.Player.Position))
            {
                Map.Maelstorm.Attack();
            }
            else if (Map.SameLocation(Map.Entrance.Position, Map.Player.Position) && Map.FountainEnabled)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
                Console.WriteLine("You win!");
                return;
            }
        }
    }
}

