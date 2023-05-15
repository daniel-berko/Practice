namespace Sum_without_highest_and_lowest_number;

// https://www.codewars.com/kata/576b93db1129fcf2200001e6

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        int sum = 0;
        int index = 1;
        
      
        if(numbers == null || numbers.Length < 2)
        {
            return 0;
        }
        else
        {
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                if(index == 1)
                {
                    index++;
                }
                else if (index == numbers.Length)
                {
                    break;
                }
                else
                {
                    sum += number;
                    index++;
                }
            }
        }
        

        return sum;
    }
}