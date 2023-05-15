// See https://aka.ms/new-console-template for more information

Random random = new Random();
int cityHealth = 15;
int manticoreHealth = 10;
int manticorePosition = random.Next(1, 100);
int currentRound = 1;


void LowerCityHealth()
{
    cityHealth--;
}

int GetCityHealth()
{
    return cityHealth;
}

void NextRound()
{
    currentRound++;
}

void LowerManticoreHealth(int damage)
{
    manticoreHealth -= damage;
}

int GetManticoreHealth()
{
    return manticoreHealth;
}

int CannonDamage(int currentRound)
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

void StatusReport()
{
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine("STATUS: Round: " + currentRound + " City: " + cityHealth + "/15" + " Manticore: " + manticoreHealth + "/10");
    Console.WriteLine("The cannon is expected to deal " + CannonDamage(currentRound) + " damage this round.");
}

void FireCannon()
{
    int range = 0;
    Console.Write("Enter the desired cannon range:");
    range = Convert.ToInt32(Console.ReadLine());
    if (range == manticorePosition)
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        LowerManticoreHealth(CannonDamage(currentRound));
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

while (cityHealth != 0 && manticoreHealth > 0)
{
    StatusReport();
    FireCannon();
    LowerCityHealth();
    NextRound();
}

