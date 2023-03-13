using System;

class Program
{
    static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != "")
        {
            string[] words = line.Split(' ');
            Console.WriteLine(words[words.Length - 1]);
        }
    }
}
