namespace Sentence_Smash;

// https://www.codewars.com/kata/53dc23c68a0c93699800041d

public class Kata
{
    public static string Smash(string[] words)
    {
        string result = "";
        int index = 0;
    
        foreach(string word in words)
        {
      
            if(index == 0)
            {
                result = word;
            }
            else
            {
                result += " " + word;
            }
      
            index++;
        }
    
        return result;
    }
}