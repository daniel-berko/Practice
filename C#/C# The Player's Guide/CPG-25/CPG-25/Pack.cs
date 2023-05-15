using System.Collections;

namespace CPG_25;


public class Pack
{
    private ArrayList Contents { get; }
    public int CountLimit { get; }
    public double WeightLimit { get; }
    public double VolumeLimit { get; }
    
    public int CurrentCount { get; set; }
    public double CurrentWeight { get; set; }
    public double CurrentVolume { get; set; }
    
    public Pack(int countLimit, double volumeLimit, double weightLimit)
    {
        CountLimit = countLimit;
        VolumeLimit = volumeLimit;
        WeightLimit = weightLimit;
        
        CurrentCount = 0;
        CurrentWeight = 0;
        CurrentVolume = 0;

        Contents = new ArrayList();
    }
    
    public bool AddToPack(InventoryItem item)
    {
        if (CurrentCount + 1 > CountLimit) return false;
        if (item.Weight + CurrentWeight > WeightLimit) return false;
        if (item.Volume + CurrentVolume > VolumeLimit) return false;

        CurrentCount++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        Contents.Add(item);
        return true;
    }

    public void ListItems()
    {   
        if (CurrentCount > 0)
        {
            Console.WriteLine("Items in your pack:");

            foreach (var content in Contents)
            {
                Console.WriteLine(content.ToString());
            }
        }
        else
        {
            Console.WriteLine("There are no items in your pack currently.");
        }
    }
}

