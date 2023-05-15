// See https://aka.ms/new-console-template for more information


// Page 82 & 83
int optionSelected = 0;
string name = "";

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What number do you want to see the price of:");
optionSelected = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your name?");
name = Console.ReadLine();
if (name == "DB")
{
    switch (optionSelected)
    {
        case 1:
            Console.WriteLine("Rope costs 5 gold.");
            break;
        case 2:
            Console.WriteLine("Torches costs 7.5 gold.");
            break;
        case 3:
            Console.WriteLine("Climbing Equipment costs 12.5 gold.");
            break;
        case 4:
            Console.WriteLine("Clean Water costs 0.5 gold.");
            break;
        case 5:
            Console.WriteLine("Machete costs 10 gold.");
            break;
        case 6:
            Console.WriteLine("Canoe costs 100 gold.");
            break;
        case 7:
            Console.WriteLine("Food Supplies costs 0.5 gold.");
            break;
        default:
            Console.WriteLine("We don't stock that here.");
            break;
    }
}
else
{
    switch (optionSelected)
    {
        case 1:
            Console.WriteLine("Rope costs 10 gold.");
            break;
        case 2:
            Console.WriteLine("Torches costs 15 gold.");
            break;
        case 3:
            Console.WriteLine("Climbing Equipment costs 25 gold.");
            break;
        case 4:
            Console.WriteLine("Clean Water costs 1 gold.");
            break;
        case 5:
            Console.WriteLine("Machete costs 20 gold.");
            break;
        case 6:
            Console.WriteLine("Canoe costs 200 gold.");
            break;
        case 7:
            Console.WriteLine("Food Supplies costs 1 gold.");
            break;
        default:
            Console.WriteLine("We don't stock that here.");
            break;
    }
}