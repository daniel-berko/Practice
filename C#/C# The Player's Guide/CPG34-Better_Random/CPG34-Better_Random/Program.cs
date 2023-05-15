// See https://aka.ms/new-console-template for more information
Random random = new Random();


public static class RandomExtensions
{
    public static double NextDouble(this Random random, double maximum)
    {
        return random.NextDouble() * maximum;
    }

    public static string NextString(this Random random, params string[] values)
    {
        return values[random.Next(values.Length)];
    }

    public static bool CoinFlip(this Random random, double odds)
    {
        return random.NextDouble() < odds;
    }
}