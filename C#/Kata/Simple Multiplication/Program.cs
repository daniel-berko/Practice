namespace Simple_Multiplication;

// https://www.codewars.com/kata/583710ccaa6717322c000105

public class Multiplier
{
    public static int Multiply(int x) 
    {
        if(x % 2 == 0)
        {
            return x * 8;
        }
        else
        {
            return x * 9;
        }
    }
}