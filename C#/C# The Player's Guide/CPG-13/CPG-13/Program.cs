// See https://aka.ms/new-console-template for more information

// Page 106
/*int AskForNumber(string text)
{
    int number = 0;
    Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (min <= number && max >= number)
        {
            return number;
        }
    }
}*/

// Page 107

// for (int x = 0; x > 0; x--)
// {
//     Console.WriteLine(x);
// }

void RecursiveMethod(int x)
{
    if (x > 0)
    {
        Console.WriteLine(x);
        RecursiveMethod(x - 1);
    }
}
RecursiveMethod(10);