// See https://aka.ms/new-console-template for more information

Potion currentPotion = Potion.Water;

while (true)
{
    Console.Clear();
    Console.WriteLine("Your current potion is: " + currentPotion);
    Console.WriteLine("Would you like to add more ingredients?");
    string? input = Console.ReadLine().ToLower();
    if (input == "no")
    {
        break;
    }
    
    Console.WriteLine("Available ingredients: stardust, snake venom, dragon breath, shadow glass, eyeshine gem");
    Console.WriteLine("What ingredient would you like to add?");

    Ingredient selected = Console.ReadLine().ToLower() switch
    {
        "stardust" => Ingredient.Stardust,
        "snake venom" => Ingredient.SnakeVenom,
        "dragon breath" => Ingredient.DragonBreath,
        "shadow glass" => Ingredient.ShadowGlass,
        "eyeshine gem" => Ingredient.EyeshineGem
    };

    currentPotion = (selected, currentPotion) switch
    {
        (Ingredient.Stardust, Potion.Water) => Potion.Elixir,
        (Ingredient.SnakeVenom, Potion.Elixir) => Potion.Poison,
        (Ingredient.DragonBreath, Potion.Elixir) => Potion.Flying,
        (Ingredient.ShadowGlass, Potion.Elixir) => Potion.Invisibility,
        (Ingredient.EyeshineGem, Potion.Elixir) => Potion.NightSight,
        (Ingredient.ShadowGlass, Potion.NightSight) => Potion.CloudyBrew,
        (Ingredient.EyeshineGem, Potion.Invisibility) => Potion.CloudyBrew,
        (Ingredient.Stardust, Potion.CloudyBrew) => Potion.Wraith,
        (_, _) => Potion.Ruined
    };

    if (currentPotion == Potion.Ruined)
    {
        Console.WriteLine("Oh no! This potion is ruined. Would you like to start over?");
        input = Console.ReadLine();
        if (input == "yes")
        {
            currentPotion = Potion.Water;
            continue;
        }
        else
        {
            break;
        }
    }
}

public enum Ingredient{Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem}
public enum Potion{Water, Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith, Ruined}