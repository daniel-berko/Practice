using System.Runtime.CompilerServices;

Arrow arrow = getArrow();
arrow.describeArrow();

Arrow getArrow()
{
    ArrowHead arrowhead = getArrowHead();
    Fletching fletching = getFletching();
    float length = getLength();

    return new Arrow(arrowhead, fletching, length);
}

ArrowHead getArrowHead()
{
    Console.WriteLine("Select the arrowhead you would like for your arrow.");
    Console.WriteLine("Your options are: steel, wood, obsidian");
    string input = Console.ReadLine();
    input.ToLower();
    return input switch
    {
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian
    };
}

Fletching getFletching()
{
    Console.Clear();
    Console.WriteLine("Select the fletching you would like for your arrow.");
    Console.WriteLine("Your options are: plastic, turkey feathers, goose feathers");
    string input = Console.ReadLine();
    input.ToLower();
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey" => Fletching.TurkeyFeathers,
        "goose" => Fletching.GooseFeathers
    };
}

float getLength()
{
    float length = 0;
    
    Console.Clear();
    Console.WriteLine("Select how long your arrows should be.");

    while (length < 60 || length > 100)
    {
        Console.WriteLine("You can choose a length between 60 and 100 centimeters long.");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}

public class Arrow
{
    private ArrowHead arrowhead { get; }
    private Fletching fletching { get; }
    private float length { get; }
    
    
    public Arrow(ArrowHead arrowhead, Fletching fletching, float length)
    {
        arrowhead = this.arrowhead;
        fletching = this.fletching;
        length = this.length;
    }

    public float getCost()
    {
        float ArrowHeadCost = arrowhead switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5
        };

        float FletchingCost = fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        float LengthCost = length * 0.05f;

        return ArrowHeadCost + FletchingCost + LengthCost;
    }

    public ArrowHead getArrowHead()
    {
        return arrowhead;
    }
    
    public Fletching getFletching()
    {
        return fletching;
    }
    
    public float returnLength()
    {
        return length;
    }

    public void describeArrow()
    {
        Console.WriteLine("This arrow has a");
        Console.WriteLine(this.getArrowHead() + " arrowhead");
        Console.WriteLine(this.getFletching() + " fletching");
        Console.WriteLine("with a length of " + this.returnLength() + " centimeters");
        Console.WriteLine("It will cost you: " + this.getCost() + " gold pieces");
    }
}
public enum ArrowHead { Steel, Wood, Obsidian }

public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }