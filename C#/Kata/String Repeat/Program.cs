namespace String_Repeat
{
    
    // https://www.codewars.com/kata/57a0e5c372292dd76d000d7e
    
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string combined = "";

            for (int i = 0; i < n; i++)
            {
                combined += s;
            }

            return combined;
        }
    }
}