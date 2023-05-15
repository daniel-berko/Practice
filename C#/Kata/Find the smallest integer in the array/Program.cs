namespace Find_the_smallest_integer_in_the_array;

// https://www.codewars.com/kata/55a2d7ebe362935a210000b2

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        int minimum = args[0];
      
        foreach(int number in args)
        {
            if(minimum > number)
            {
                minimum = number;
            }
        }
      
        return minimum;
    }
}