namespace Descending_Order;

// https://www.codewars.com/kata/5467e4d82edf8bbf40000155

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        if(num == 0)
        {
            return 0;
        }
        // Bust a move right here
        string stringify = num.ToString();
        List<int> sorted = new List<int>();

        foreach (char c in stringify)
        {
            int i = c - '0';
            sorted.Add(i);
        }
        sorted = sorted.OrderBy(x => x).ToList();
        sorted.Reverse();
        string outputString = "";
        int output = 0;
        
        foreach (int n in sorted)
        {
            outputString += n;
        }
    
        Int32.TryParse(outputString, out output);
        
        return output;
    }
}