namespace How_good_are_you_really;

// https://www.codewars.com/kata/5601409514fc93442500010b

public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        //Insert brain here
        int average = 0;
    
        foreach(int point in ClassPoints)
        {
            average += point;
        }
    
        average = average / ClassPoints.Length;
    
        if(average < YourPoints)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}