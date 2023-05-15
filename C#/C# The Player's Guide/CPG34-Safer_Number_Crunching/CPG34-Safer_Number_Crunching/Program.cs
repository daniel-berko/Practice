// See https://aka.ms/new-console-template for more information



/*while (true)
{
    Console.Write("Please enter a whole integer: ");
    string input = Console.ReadLine()!;
    int result;

    if (int.TryParse(input, out result))
    {
        Console.WriteLine("Thanks! Your number is: ");
        Console.WriteLine(result);
        return;
    }
}*/

/*while (true)
{
    Console.Write("Please enter a double: ");
    string input = Console.ReadLine()!;
    double result;

    if (double.TryParse(input, out result))
    {
        Console.WriteLine("Thanks! Your number is: ");
        Console.WriteLine(result);
        return;
    }
}*/

while (true)
{
    Console.Write("Please enter a boolean: ");
    string input = Console.ReadLine()!;
    bool result;

    if (bool.TryParse(input, out result))
    {
        Console.WriteLine("Thanks! Your boolean's value is: ");
        Console.WriteLine(result);
        return;
    }
}