namespace Century_From_Year;

// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        int offset = 1;
        if(year % 100 == 0)
        {
            offset = 0;
        }
        year = (int)year / 100;
        year += offset;
        Console.WriteLine(year);
        return year;
    }
}