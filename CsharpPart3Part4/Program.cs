using System;

class LoginProgram
{
    static void Main()
    {
        string username, password;

        Console.Write("Enter your username: ");
        username = Console.ReadLine();

        Console.Write("Enter your password: ");
        password = Console.ReadLine();

        if ((username == "alex" && password == "sunshine") ||
            (username == "emma" && password == "haskell"))
        {
            Console.WriteLine("Login successful.");
        }
        else
        {
            Console.WriteLine("Incorrect username or password.");
        }

        Console.ReadLine();
    }
}
