// See https://aka.ms/new-console-template for more information

// Page 75
int number = 0;
Console.WriteLine("Please enter the number:");
number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

// Page 78
int x = 0;
int y = 0;

Console.WriteLine("Please enter the X coordinate:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the Y coordinate:");
y = Convert.ToInt32(Console.ReadLine());
if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is to the northwest!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is to the north!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is to the northeast!");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("The enemy is to the west!");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is to the east!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is to the southwest!");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("The enemy is to the south!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("The enemy is to the southeast!");
}
else
{
    Console.WriteLine("We are not sure where the enemy is!");
}