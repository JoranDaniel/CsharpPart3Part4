using System;

class Program
{
    static void Main(string[] args)
    {
        // Current year
        int currentYear = DateTime.Now.Year;

        // Variables for longest name and highest age
        string longestName = null;
        int highestAge = int.MinValue;

        while (true)
        {
            Console.Write("Enter name and birth year (or empty line to finish): ");
            string input = Console.ReadLine();

            // Check if the user wants to stop entering names
            if (string.IsNullOrWhiteSpace(input))
            {
                if (longestName == null && highestAge == int.MinValue)
                {
                    Console.WriteLine("No names or birth years entered.");
                }
                else
                {
                    Console.WriteLine("Longest name: " + longestName);
                    Console.WriteLine("Highest age: " + highestAge);
                }

                Console.Write("Do you want to continue entering names? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response != "y")
                {
                    break;
                }

                continue;
            }

            // Parse input into name and birth year
            string[] parts = input.Split(',');
            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid input. Please enter name and birth year separated by a comma.");
                continue;
            }

            string name = parts[0].Trim();
            int birthYear;
            if (!int.TryParse(parts[1].Trim(), out birthYear))
            {
                Console.WriteLine("Invalid input. Birth year must be an integer.");
                continue;
            }

            // Calculate age
            int age = currentYear - birthYear;

            // Update longest name and highest age if necessary
            if (longestName == null || name.Length > longestName.Length)
            {
                longestName = name;
            }
            if (age > highestAge)
            {
                highestAge = age;
            }
        }
    }
}