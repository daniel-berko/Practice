namespace Return_Negative;

// https://www.codewars.com/kata/55685cd7ad70877c23000102

public static class Kata
{
    public static int MakeNegative(int number)
    {
        // Code?
        if(number < 0)
        {
            return number;
        }
        else
        {
            return number * -1;
        }
        return 0;
    }
}