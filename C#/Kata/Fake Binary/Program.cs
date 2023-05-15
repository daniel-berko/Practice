namespace Fake_Binary;

// https://www.codewars.com/kata/57eae65a4321032ce000002d

public class Kata
{
    public static string FakeBin(string x)
    {
        string y = "";
        
        x = x.Replace('1', '0');
        x = x.Replace('2', '0');
        x = x.Replace('3', '0');
        x = x.Replace('4', '0');
        x = x.Replace('5', '1');
        x = x.Replace('6', '1');
        x = x.Replace('7', '1');
        x = x.Replace('8', '1');
        x = x.Replace('9', '1');

        return x;
    }
}