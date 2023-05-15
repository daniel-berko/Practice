namespace Are_You_Playing_Banjo;

// https://www.codewars.com/kata/53af2b8861023f1d88000832

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        char first = Char.ToLower(name[0]);

        //Implement me
        if(first.Equals('r'))
        {
            return name + " plays banjo";
        }
        else{
            return name + " does not play banjo";
        }
    }
}