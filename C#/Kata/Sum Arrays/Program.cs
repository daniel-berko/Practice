namespace Sum_Arrays;

// https://www.codewars.com/kata/53dc54212259ed3d4f00071c

public class Kata
{
    public static double SumArray(double[] array)
    {
        double sum = 0;
    
        if(array.Length == 0)
        {
            return 0;
        }
        else
        {
            foreach(double number in array)
            {
                sum += number;
            }
      
            return sum;
        }
    }
}