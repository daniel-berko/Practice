// See https://aka.ms/new-console-template for more information

// Page 88
int picked_number = 0;
int guessed_number = 0;

Console.WriteLine("User 1, enter a number between 0 and 100:");
picked_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User 2, guess the number.");

while (true)
{
    Console.WriteLine("What is your guess?");
    guessed_number = Convert.ToInt32(Console.ReadLine());

    if (guessed_number > picked_number)
    {
        Console.WriteLine(guessed_number + " is too high.");
    }
    else if (guessed_number < picked_number)
    {
        Console.WriteLine(guessed_number + " is too low.");
    }
    else
    {
        Console.WriteLine("You guessed correctly!");
        break;
    }
}

// Page 89
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0 && i > 0)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(i + ". Electric-Fire blast");
    }
    else if (i % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(i + ". Fire blast");
    }
    else if (i % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine(i + ". Electric blast");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(i + ". Normal blast");
    }
}