namespace Beginner_Series_2_Clock;

// https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a

public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        //#Happy Coding! ^_^
        int seconds = 1000;
        int minutes = 60000;
        int hours = 3600000;
        int result = (h * hours) + (m * minutes) + (s * seconds);
      
        return result;
    }
}