// See https://aka.ms/new-console-template for more information

/*
- Pick a random number between 0 & 9 to represent the oatmeal cookie
- Allow two players to take turn and pick a number between 0 & 9
- If a player picks a number that has already been selected make them pick another
- If a player picks the oatmeal cookie's number throw an exception
*/

try
{
    Random random = new Random();
    List<int> availableNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    List<int> removedNumbers = new List<int>();
    int selectedNumber;
    int playerNumber = 1;
    int oatNumber = random.Next(1, 9);
    // Console.WriteLine(oatNumber);

    while (true)
    {
        if (playerNumber % 2 != 0)
        {
            Console.Write("Player 1 pick a number between 0 & 9: ");
        }
        else
        {
            Console.Write("Player 2 pick a number between 0 & 9: ");
        }

        selectedNumber = Int32.Parse(Console.ReadLine());


        if (selectedNumber == oatNumber)
        {
            throw new Exception();
        }


        if (!availableNumbers.Contains(selectedNumber))
        {
            Console.WriteLine(selectedNumber + " is not a valid option!");
            continue;
        }
        else
        {
            availableNumbers.Remove(selectedNumber);
            removedNumbers.Add(selectedNumber);
            playerNumber++;

            // availableNumbers.ForEach(number => Console.WriteLine(number));
            // Console.WriteLine("-----------");
            // removedNumbers.ForEach(number => Console.WriteLine(number));
        }

    }
}
catch(Exception)
{
    Console.WriteLine("You picked the wrong number.");
    Console.WriteLine("Ciao!");
}