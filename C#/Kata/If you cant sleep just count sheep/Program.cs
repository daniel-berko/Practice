using System.Text;

// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077

namespace If_you_cant_sleep_just_count_sheep;

public static class Kata
{
    public static string CountSheep(int n)
    {
        StringBuilder final = new StringBuilder();
    
        for(int i = 1; i < n + 1; i++)
        {
            final.Append($"{i} sheep...");
        }
    
        return final.ToString();
    }
}