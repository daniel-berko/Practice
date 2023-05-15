// See https://aka.ms/new-console-template for more information

// Page 53
int tr_base = 0;
int tr_height = 0;
double size = 0;

Console.WriteLine("Hello! Let's calculate the size of your triangle.");
Console.WriteLine("Please enter the base of the triangle:");
tr_base = Console.Read();
Console.WriteLine("Please enter the base of the triangle:");
tr_height = Console.Read();
size = (tr_height * tr_base) / 2;
Console.WriteLine("The size of the triangle is: " + size);

// Page 56

int c_eggs = 0;
int bear_eggs = 0;
int sister_eggs = 0;


Console.WriteLine("Please enter the number of eggs laid today:");
c_eggs = Console.Read();

bear_eggs = c_eggs % 4;
sister_eggs = c_eggs / 4;

Console.WriteLine("Each sister gets " + sister_eggs + " eggs today.");
if (bear_eggs == 0)
{
    Console.WriteLine("The duckbear won't get any eggs today :(");
}
else if (bear_eggs == 1)
{
    Console.WriteLine("The duckbear will get one egg today!");
}
else
{
    Console.WriteLine("The duckbear will get " + bear_eggs + " eggs today");
}

// Page 54

int estates = 0;
int duchies = 0;
int provinces = 0;
int total = 0;

Console.WriteLine("Let's calculate the points for your kingdom.");
Console.WriteLine("Please enter the number of estates in the kingdom:");
estates = Console.Read();
Console.WriteLine("Please enter the number of duchies in the kingdom:");
duchies = Console.Read();
Console.WriteLine("Please enter the number of provinces in the kingdom:");
provinces = Console.Read();
total = estates + duchies * 3 + provinces * 5;
Console.WriteLine("The total points achieved by the kingdom is: " + total);