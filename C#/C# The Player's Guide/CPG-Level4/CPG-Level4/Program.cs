// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
// Describes the thing and stores it in 'a'
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Describes the thing further and stores it in 'b'
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");