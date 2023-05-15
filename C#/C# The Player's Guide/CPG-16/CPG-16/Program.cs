// See https://aka.ms/new-console-template for more information

States state = States.Locked;
string selected;

while (true)
{
    Console.Write("The chest is currently " + state + ". What would you like to do? ");
    selected = Console.ReadLine();
    if (state == States.Open && selected == "close")
    {
        state = States.Closed;
    }
    else if (state == States.Closed && selected == "lock")
    {
        state = States.Locked;
    }
    else if (state == States.Locked && selected == "unlock")
    {
        state = States.Closed;
    }
    else if (state == States.Closed && selected == "open")
    {
        state = States.Open;
    }
    else
    {
        Console.WriteLine("You can't currently " + selected + " the chest.");
        Console.WriteLine("Please select another option.");
    }
}
enum States
{
    Open,
    Closed,
    Locked
}