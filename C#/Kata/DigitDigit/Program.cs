namespace DigitDigit;

// https://www.codewars.com/kata/546e2562b03326a88e000020

public class Kata
{
    public static int SquareDigits(int n)
    {
        string stringify = n.ToString();
        List<int> outputList = new List<int>();

        foreach(char c in stringify)
        {
            int i = c - '0';
            i *= i;
            outputList.Add(i);
        }

        string stringOutput = "";
        
        foreach (int x in outputList)
        {
            stringOutput += x;
        }

        int output = 0;
        Int32.TryParse(stringOutput, out output);
        
        return output;
    }
}