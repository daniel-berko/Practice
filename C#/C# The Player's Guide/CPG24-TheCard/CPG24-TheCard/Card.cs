using System.Diagnostics;

namespace CPG24_TheCard;

public class Card
{
    public Ranks Rank { get; }
    public Colors Color { get; }
    public Types Type { get; }

    public Card(Ranks rank, Colors color)
    {
        Rank = rank;
        Color = color;
        Type = rank switch
        {
            Ranks.Ampersand => Types.Symbol,
            Ranks.Caret => Types.Symbol,
            Ranks.Percent => Types.Symbol,
            Ranks.DollarSign => Types.Symbol,
            _ => Types.Number
        };

    }

    public override string ToString()
    {
        return "The " + Rank + " of " + Color;
    }
}
public enum Colors {Red, Green, Blue, Yellow}
public enum Ranks {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Ampersand, Caret}
public enum Types {Number, Symbol}