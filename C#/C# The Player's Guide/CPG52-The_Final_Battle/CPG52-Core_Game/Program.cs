// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using CPG52_Core_Game;
using CPG52_Core_Game.Players;

Hero player = new Hero();
Computer computer = new Computer();

Battle battle = new Battle(player, computer);

Console.Write("Please name your character: ");
Console.ForegroundColor = ConsoleColor.DarkCyan;
player.Parties[0].ReturnMembers()[0].Rename(Console.ReadLine() ?? throw new Exception("Please enter a name."));
Console.ForegroundColor = ConsoleColor.Gray;

while (true)
{
    Console.WriteLine("Available game modes:");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("1 - Player VS. Computer");
    Console.WriteLine("2 - Computer VS. Computer");
    Console.WriteLine("3 - Player VS. Player");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Please select a game mode: ");
    Console.ForegroundColor = ConsoleColor.DarkCyan;

    string choice = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.ForegroundColor = ConsoleColor.Gray;
    switch (choice)
    {
        case("1"):
            Console.WriteLine();
            battle.Commence("semi-auto");
            break;
        case("2"):
            Console.WriteLine();
            battle.Commence("full-auto");
            break;
        case("3"):
            Console.WriteLine();
            battle.Commence("manual");
            break;
    }
    break;
}

