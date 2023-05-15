// See https://aka.ms/new-console-template for more information

// Page 94
/*int[] numbers = new int[5];
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;


Console.WriteLine("Please enter 5 numbers:");
Console.WriteLine("Number 1:");
number1 = Convert.ToInt32(Console.ReadLine());
numbers[0] = number1;
Console.WriteLine("Number 2:");
number2 = Convert.ToInt32(Console.ReadLine());
numbers[1] = number2;
Console.WriteLine("Number 3:");
number3 = Convert.ToInt32(Console.ReadLine());
numbers[2] = number3;
Console.WriteLine("Number 4:");
number4 = Convert.ToInt32(Console.ReadLine());
numbers[3] = number4;
Console.WriteLine("Number 5:");
number5 = Convert.ToInt32(Console.ReadLine());
numbers[4] = number5;

int[] numbers2 = { number1, number2, number3, number4, number5 };

Console.WriteLine("The contents of the first array:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("The contents of the second array:");
for (int i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine(numbers2[i]);
}*/

// Page 95 
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};


// Minimum For Loop
int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
    {
        currentSmallest = array[index];
    }
}
Console.WriteLine(currentSmallest);

// Minimum Foreach Loop
foreach (var number in array)
{
    if (number < currentSmallest)
    {
        currentSmallest = number;
    }
}
Console.WriteLine(currentSmallest);


// Average For loop
int total = 0;
for (int index = 0; index < array.Length; index++)
{
    total += array[index];
}

float average = (float)total / array.Length;
Console.WriteLine(average);

// Average Foreach Loop
foreach (var number in array)
{
    total += number;
}
average = (float)total / array.Length;
Console.WriteLine(average);