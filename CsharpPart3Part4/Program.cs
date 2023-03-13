using System;

class Program
{
    static void Main(string[] args)
    {
        string name, oldestName = "";
        int age, oldestAge = 0;

        while (true)
        {
            Console.Write("Vul je naam in (of druk op enter om te stoppen): ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                break;
            }

            Console.Write("Vul je leeftijd in: ");
            age = int.Parse(Console.ReadLine());

            if (age > oldestAge)
            {
                oldestName = name;
                oldestAge = age;
            }
        }

        if (string.IsNullOrEmpty(oldestName))
        {
            Console.WriteLine("Er zijn geen namen ingevoerd.");
        }
        else
        {
            Console.WriteLine("Naam van de oudste persoon: " + oldestName);
        }

        Console.WriteLine("Druk op een toets om af te sluiten.");
        Console.ReadKey();
    }
}