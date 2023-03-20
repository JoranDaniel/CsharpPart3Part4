//4-23
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        while (input != "end")
        {
            Console.Write("geef een nummer of schrijf 'end' om te stoppen ");
            input = Console.ReadLine();

            if (input != "end")
            {
                int num = int.Parse(input);
                int uitkomst = num * num * num;
                Console.WriteLine($"de uitkomst van 4-23 is {uitkomst}");
            }
        }

        Console.WriteLine("afsluiten die handel");
    }
}