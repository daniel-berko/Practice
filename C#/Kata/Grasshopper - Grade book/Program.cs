namespace Grasshopper___Grade_book;

// https://www.codewars.com/kata/55cbd4ba903825f7970000f5

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        int average = (s1 + s2 + s3) / 3;
    
        if(average >= 90)
        {
            return 'A';
        }
        else if(average >= 80)
        {
            return 'B';
        }
        else if(average >= 70)
        {
            return 'C';
        }
        else if(average >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}