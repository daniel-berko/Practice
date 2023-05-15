// See https://aka.ms/new-console-template for more information

int targetRow = 0;
int targetColumn = 0;

Console.Title = "The Defense of Consolas";
Console.WriteLine("What is the target row?");
targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the target column?");
targetColumn = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Deploy to:");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"First mage to row {targetRow}, column {targetColumn + 1}");
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"First mage to row {targetRow - 1}, column {targetColumn}");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"First mage to row {targetRow + 1}, column {targetColumn + 1}");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine($"First mage to row {targetRow}, column {targetColumn - 1}");
Console.Beep();