namespace CPG24_PasswordValidator;
// Passwords must be at least 6 letters long and no more than 13 letters long.
// Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
// Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.


public class PasswordValidator
{
    
    public void Greeting()
    {
        Console.WriteLine("Please enter a new password. It must be: ");
        Console.WriteLine("- at least 6 letters long and no more than 13 letters long");
        Console.WriteLine("- at least one uppercase letter, one lowercase letter, and one number");
        Console.WriteLine("- cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it");
    }

    private bool CheckLength(string password)
    {
        if (password.Length > 13 || password.Length < 6)
        {
            Console.WriteLine("Invalid length");
            return false;
        }
        else
        {
            return true;
        }
    }

    private bool CheckLowercase(string password)
    {
        foreach (var letter in password)
        {
            if (char.IsLower(letter))
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckUppercase(string password)
    {
        foreach (var letter in password)
        {
            if (char.IsUpper(letter))
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckNumber(string password)
    {
        foreach (var letter in password)
        {
            if (char.IsNumber(letter))
            {
                return true;
            }
        }
        return false;
    }
    
    private bool ContainsLetterT(string password)
    {
        foreach (var letter in password)
        {
            if (letter == 't' || letter == 'T')
            {
                return true;
            }
        }
        return false;
    }

    private bool ContainsAmpersend(string password)
    {
        foreach (var letter in password)
        {
            if (letter == '&')
            {
                return true;
            }
        }
        return false;
    }

    private bool IsNull(string password)
    {
        if (password == null)
        {
            return true;
        }
        return false;
    }

    public bool ValidPassword(string password)
    {
        if (IsNull(password)) return false;
        if (!CheckLength(password)) return false;
        if (!CheckLowercase(password)) return false;
        if (!CheckUppercase(password)) return false;
        if (!CheckNumber(password)) return false;
        if (ContainsLetterT(password)) return false;
        if (ContainsAmpersend(password)) return false;

        return true;
    }

    public void CheckPassword()
    {
        while (true)
        {
            Console.Write("Please enter new password: ");
            string pw = Console.ReadLine();

            if (ValidPassword(pw))
            {
                Console.Clear();
                Console.WriteLine("The password is valid. Good job!");
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The password is invalid.");
            }
        }
    }
}
