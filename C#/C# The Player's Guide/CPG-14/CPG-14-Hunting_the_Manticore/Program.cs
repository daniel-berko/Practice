// See https://aka.ms/new-console-template for more information

int cityHealth = 15;
int manticoreHealth = 10;
int manticorePosition = new int();
int currentRound = 1;

void LowerCityHealth()
{
    cityHealth--;
}

int getCityHealth()
{
    return cityHealth;
}

void nextRound()
{
    currentRound++;
}

void lowerManticoreHealth(int damage)
{
    manticoreHealth -= damage;
}

int getManticoreHealth()
{
    return manticoreHealth;
}

int cannonDamage(int currentRound)
{
    int damage = 0;
    if (currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        damage = 10;
    }
    else if (currentRound % 3 == 0 || currentRound % 5 == 0)
    {
        damage = 3;
    }
    else
    {
        damage = 1;
    }
    return damage;
}

void statusReport()
{
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine("STATUS: Round: " + currentRound + " City: " + cityHealth + "/15" + " Manticore: " + manticoreHealth + "/10");
    Console.WriteLine("The cannon is expected to deal " + cannonDamage(currentRound) + " damage this round.");
}

void fireCannon()
{
    int range = 0;
    Console.Write("Enter the desired cannon range:");
    range = Convert.ToInt32(Console.ReadLine());
    if (range == manticorePosition)
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        lowerManticoreHealth(cannonDamage(currentRound));
        if (manticoreHealth < 1)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
    }
    else if (range < manticorePosition)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
}

Console.Write("Player 1, how far away from the city do you want to station the Manticore?");
manticorePosition = Convert.ToInt32(Console.ReadLine());
if (manticorePosition > 100)
{
    manticorePosition = 100;
}
else if (manticorePosition < 0)
{
    manticorePosition = 1;
}
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityHealth != 0 && manticoreHealth > 0)
{
    statusReport();
    fireCannon();
    LowerCityHealth();
    nextRound();
}

