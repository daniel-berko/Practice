// See https://aka.ms/new-console-template for more information
string choice = "";
(Type type, Ingredient ingredient, Seasoning seasoning) food = getSoup();
Console.WriteLine("Your choice is:");
Console.WriteLine($"{food.seasoning} {food.ingredient} {food.type}");

(Type, Ingredient, Seasoning) getSoup()
{
    Type type = getType();
    Ingredient ingredient = getIngredient();
    Seasoning seasoning = getSeasoning();
    Console.Clear();
    
    return (type, ingredient, seasoning);
}

Type getType()
{
    Console.WriteLine("What kind of meal are you looking for?");
    Console.WriteLine("Your options are:\nSoup\nStew\nGumbo");
    choice = Console.ReadLine();
    choice.ToLower();
    return choice switch
    {
        "soup" => Type.Soup,
        "stew" => Type.Stew,
        "gumbo" => Type.Gumbo
    };
}

Ingredient getIngredient()
{
    Console.Clear();
    Console.WriteLine("OK. What main ingredient would you prefer?");
    Console.WriteLine("Your options are:\nMushrooms\nChicken\nCarrots\nPotatoes");
    choice = Console.ReadLine();
    choice.ToLower();
    return choice switch
    {
        "mushrooms" => Ingredient.Mushrooms,
        "mushroom" => Ingredient.Mushrooms,
        "chicken" => Ingredient.Chicken,
        "carrots" => Ingredient.Carrots,
        "carrot" => Ingredient.Carrots,
        "potatoes" => Ingredient.Potatoes,
        "potato" => Ingredient.Potatoes
    };
}

Seasoning getSeasoning()
{
    Console.Clear();
    Console.WriteLine("OK. What seasoning would you like?");
    Console.WriteLine("Your options are:\nHot\nSalty\nSweet");
    choice = Console.ReadLine();
    choice.ToLower();
    return choice switch
    {
        "hot" => Seasoning.Hot,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

enum Type {Soup, Stew, Gumbo}
enum Ingredient {Mushrooms, Chicken, Carrots, Potatoes}
enum Seasoning {Hot, Salty, Sweet}