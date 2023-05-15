// See https://aka.ms/new-console-template for more information

List<int> original = new List<int>{1,9,2,8,3,7,4,6,5};

IEnumerable<int> ThreeLensesList(List<int> input)
{
    List<int> filtered = new List<int>();
    
    // Add evne numbers to new temp List
    foreach (var number in input)
    {
        if (number % 2 == 0)
        {
            filtered.Add(number);
        }
    }

    // Multiply elements of List
    for (int i = 0; i < filtered.Count; i++)
    {
        filtered[i] = filtered[i] * 2;
    }

    // Reorder List
    filtered.Sort();
    
    
    return filtered;
}

foreach (var number in ThreeLensesList(original))
{
    Console.WriteLine(number);
}

Console.WriteLine("--------------------");

IEnumerable<int> ThreeLensesQuery(List<int> input)
{
    var filtered = 
        from i in input
        where i % 2 == 0
        orderby i
        select i * 2;

    return filtered;
}

foreach (var number in ThreeLensesQuery(original))
{
    Console.WriteLine(number);
}

Console.WriteLine("--------------------");

IEnumerable<int> ThreeLensesMethod(List<int> input)
{
    var filtered = input
        .Where(i => i % 2 == 0)
        .OrderBy(i => i)
        .Select(i => i * 2);

    return filtered;
}

foreach (var number in ThreeLensesMethod(original))
{
    Console.WriteLine(number);
}