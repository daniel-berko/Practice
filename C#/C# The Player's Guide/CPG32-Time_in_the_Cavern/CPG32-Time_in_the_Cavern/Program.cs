// See https://aka.ms/new-console-template for more information

using CPG31_The_Fountain_of_Objects;
using CPG31_The_Fountain_of_Objects.Monsters;

while (true)
{
    DateTime startTime = DateTime.Now;
    DateTime endTime = new DateTime();
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search " +
                      "of the Fountain of Objects.");
    Console.WriteLine("Light is visible only in the entrance, and no other light is seen anywhere in the caverns.");
    Console.WriteLine("You must navigate the Caverns with your other senses.");
    Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
    // Console.WriteLine("PITS: Look out for pits. You will feel a breeze if a pit is in an adjacent room. " +
    //                   "If you enter a room with a pit, you will die");
    // Console.WriteLine("MAELSTORMS: Maelstroms are violent forces of sentient wind. Entering a room with one could" +
    //                   " transport you to any other location in the caverns. You will be able to hear their growling" +
    //                   " and groaning in nearby rooms");
    // Console.WriteLine("AMAROKS: Amaroks roam the caverns. Encountering one is certain death, but you can smell their" +
    //                   " rotten stench in nearby rooms.");
    // Console.WriteLine("ARROWS: You carry with you a bow and a quiver of arrows. You can use them to shoot monsters" +
    //                   " in the caverns but be warned: you have a limited supply");
    Console.WriteLine("What size map would you like to play on? Your options are: small, medium, large.");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Selection: ");
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
            Console.WriteLine("What would you like to do? ");
            Console.Write("Command: ");
            Map.Player.Act();

            if (Map.SameLocation(Map.Pit.Position, Map.Player.Position))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You have fallen into a pit and died.");
                endTime = DateTime.Now;
                TimeSpan timePassed = endTime - startTime;
                Console.WriteLine(timePassed);
                return;
            }
            if (Map.SameLocation(Map.Amarok.Position, Map.Player.Position))
            {
                Map.Amarok.Attack();
                endTime = DateTime.Now;
                TimeSpan timePassed = endTime - startTime;
                Console.WriteLine(timePassed);
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
                
                endTime = DateTime.Now;
                TimeSpan timePassed = endTime - startTime;
                Console.WriteLine($"Time passed: {timePassed}");
                return;
            }
        }
    }
}

