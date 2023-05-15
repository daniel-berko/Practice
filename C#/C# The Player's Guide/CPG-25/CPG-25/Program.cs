// See https://aka.ms/new-console-template for more information


using CPG_25;
using CPG_25.Items;

Pack pack1 = new Pack(30,30,30);

while (true)
{
    Console.WriteLine("Hello! Your pack is currently at:");
    Console.WriteLine("Item count: " + pack1.CurrentCount + "/" + pack1.CountLimit);
    Console.WriteLine("Weight: " + pack1.CurrentWeight + "/" + pack1.WeightLimit);
    Console.WriteLine("Space: " + pack1.CurrentVolume + "/" + pack1.VolumeLimit);
    pack1.ListItems();
    Console.WriteLine("What would you like to add?");

    Console.WriteLine("Your options:");
    Console.WriteLine("Arrow");
    Console.WriteLine("Bow");
    Console.WriteLine("Food");
    Console.WriteLine("Rope");
    Console.WriteLine("Sword");
    Console.WriteLine("Water");

    string selected = Console.ReadLine().ToLower();


    InventoryItem item = selected switch
    {
        "arrow" => new Arrow(),
        "bow" => new Bow(),
        "food" => new Food(),
        "rope" => new Rope(),
        "sword" => new Sword(),
        "water" => new Water()
    };

    if (!pack1.AddToPack(item))
    {
        Console.WriteLine("There's not enough space in your pack!");
    }
}