// See https://aka.ms/new-console-template for more information

using CPG24_TheCard;

Colors[] colors = new Colors[] { Colors.Blue ,Colors.Green, Colors.Red, Colors.Yellow};
Ranks[] ranks = new Ranks[] { Ranks.Ampersand ,Ranks.Caret,Ranks.Eight,Ranks.Five,Ranks.Four,Ranks.Nine,Ranks.One,Ranks.Percent,Ranks.Seven,Ranks.Six,Ranks.Ten,
    Ranks.Three,Ranks.Two,Ranks.DollarSign};
    
    foreach(Colors color in colors)
{
    foreach (Ranks rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine(card.ToString());
    }
}