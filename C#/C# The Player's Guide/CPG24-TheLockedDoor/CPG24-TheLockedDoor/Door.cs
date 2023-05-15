namespace CPG24_TheLockedDoor;

public class Door
{
    private int Passcode { get; set; }
    private States State { get; set; }

    public Door(int passcode)
    {
        Passcode = passcode;
        State = States.Locked;
    }

    public void ChangeState()
    {
        while (true)
        {
            Greetings();
            string newState = Console.ReadLine();
            newState = newState.ToLower();
            switch (newState)
        {
            case "close":
                if (State == States.Open)
                {
                    State = States.Closed;
                    Console.WriteLine("The door has been closed.");
                }
                else
                {
                    Console.WriteLine("You can't do that right now. The door is " + State);
                }

                break;
            case "lock":
                if (State == States.Closed)
                {
                    State = States.Locked;
                    Console.WriteLine("The door has been locked.");
                }
                else
                {
                    Console.WriteLine("You can't do that right now. The door is " + State);
                }

                break;
            case "open":
                if (State == States.Closed)
                {
                    State = States.Open;
                    Console.WriteLine("The door has been opened.");
                }
                else
                {
                    Console.WriteLine("You can't do that right now. The door is " + State);
                }

                break;
            case "unlock":
                if (State == States.Locked)
                {
                    while (true)
                    {
                        Console.Write("Please enter the passcode to unlock the door: ");
                        int guess = Convert.ToInt32(Console.ReadLine());
                        if (guess == Passcode)
                        {
                            Console.WriteLine("The door has been unlocked.");
                            State = States.Closed;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The passcode didn't match.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You can't do that right now. The door is " + State);
                }

                break;
            case "change passcode":
                while (true)
                {
                    Console.Write("Please enter old passcode first:" );
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == Passcode)
                    {
                        Console.Write("Now the new passcode:- ");
                        int newPasscode = Convert.ToInt32(Console.ReadLine());
                        Passcode = newPasscode;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The passcode didn't match.");
                    }
                }
                break;
            case "exit":
                Console.WriteLine("Ok, bye!");
                return;
        }
        }
        
    }

    private void Greetings()
    {
        Console.WriteLine("The door is currently: " + State);
        Console.WriteLine("Your options are: open, close, lock, unlock, change passcode, exit");
        Console.Write("What would you like to do? ");
    }

    public void CreateDoor()
    {
        Console.WriteLine("Please enter your passcode:");
        int passcode = Convert.ToInt32(Console.ReadLine());
        Door door = new Door(passcode);
    }
}

public enum States
{
    Open,
    Closed,
    Locked
}