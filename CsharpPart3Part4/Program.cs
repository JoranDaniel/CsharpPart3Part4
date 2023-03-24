using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] names = File.ReadAllLines("C:\\Users\\joran\\OneDrive\\Documenten\\ROC Nijmegen\\Vakken\\C#\\ConsoleApp2\\ConsoleApp2\\guestlist.txt");

        Console.WriteLine("Enter names, an empty line quits.");

        while (true)
        {
            Console.Write("> ");
            string name = Console.ReadLine().Trim();

            if (name == "")
                if (name == "")
                {
                    break;
                }

            bool onList = false;

            foreach (string guestName in names)
            {
                if (guestName.ToLower() == name.ToLower())
                {
                    onList = true;
                    break;
                }
            }

            if (onList)
            {
                Console.WriteLine("The name is on the list.");
            }
            else
            {
                Console.WriteLine("The name is not on the list.");
            }
        }

        Console.WriteLine("\nThank you!");
    }
}