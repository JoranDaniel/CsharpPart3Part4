internal class Program
{
    private static bool stop;

    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("0. Quit");
        Console.WriteLine("1. Tiny Calculator");
        Console.WriteLine("2. Even or Odd");
        Console.WriteLine("3. Echo");
        Console.WriteLine("4. Answer to Life");
        Console.WriteLine("5. Counting Numbers");
        Console.WriteLine("6. Sum of Numbers");
        Console.WriteLine("7. Amount and Sum");
        Console.WriteLine("8. Iterating to Input");
        Console.WriteLine("9. Numbers and Calculations");
        Console.WriteLine("10. Boss Baby");
        Console.WriteLine("11. Print Phrase");
        Console.WriteLine("12. Print Phrase Amount");
        Console.WriteLine("13. Print Until Number");
        Console.WriteLine("14. Print Until One");
        Console.WriteLine("15. Division");
        Console.WriteLine("16. Divisible in Range");

        Console.Write("Enter the number of the program you want to run: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 0:
                stop = true;
                break;

            case 1:
                tinyCalc();
                break;
            case 2:
                evenOrOdd();
                break;
            case 3:
                echo();
                break;
            case 4:
                answerToLife();
                break;
            case 5:
                countingNumbers();
                break;
            case 6:
                sumOfNumbers();
                break;
            case 7:
                amountAndSum();
                break;
            case 8:
                iteratingtoInput();
                break;
            case 9:
                numbersAndCalculations();
                break;
            case 10:
                bossBaby();
                break;
            case 11:
                printPhrase();
                break;
            case 12:
                printPhraseAmount();
                break;
            case 13:
                printUntilNumber();
                break;
            case 14:
                printUntilOne();
                break;
            case 15:
                division();
                break;
            case 16:
                divisbleInRange();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    private static void amountAndSum()
    {
        throw new NotImplementedException();
    }

    public static void tinyCalc()
    {
        Console.Write("Give the first number!: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Give the second number!: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine(sum);

        int sum2 = num1 - num2;
        Console.WriteLine(sum2);

        int sum3 = num1 * num2;
        Console.WriteLine(sum3);

        int sum4 = num1 / num2;
        Console.WriteLine(sum4);
    }

    public static void evenOrOdd()
    {
        Console.Write("Give a number: ");
        int evenOrOdd = Convert.ToInt32(Console.ReadLine());

        if (evenOrOdd % 2 == 0)
        {
            Console.WriteLine(evenOrOdd);
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine(evenOrOdd);
            Console.WriteLine("Number is odd");
        }

    }

    public static void echo()
    {
        Console.Write("Give the first Word!: ");
        string word1 = Console.ReadLine();
        Console.Write("Give the second Word!: ");
        string word2 = Console.ReadLine();

        if (word1 == word2)
        {
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine("Echo!");
        }
        else
        {
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine("Nope!"); ;
        }
    }

    public static void answerToLife()
    {
        int num = 42;
        int input = 0;

        while (input != num)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);

        }

    }

    public static void countingNumbers()
    {
        int total = 0;
        int input = 1;

        Console.Write("Give a number: ");
        input = Convert.ToInt32(Console.ReadLine());

        while (input != 0)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            total++;

        }
        Console.WriteLine(total);
    }

    public static void sumOfNumbers()
    {

        Console.Write("Give a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = input;

        while (input != 0)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input > 0)
            {
                sum = sum + input;
            }
            else
            {
                sum = sum - input;
            }
        }

        Console.WriteLine(sum);
    }

    public static void amountAndSum(string readNumbers)
    {
        int total = 0;

        Console.Write("Give a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = input;

        while (input != 0)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            total++;

            if (input > 0)
            {
                sum = sum + input;
            }
            else
            {
                sum = sum - input;
            }
        }

        Console.WriteLine(sum);
        Console.WriteLine(total);
    }

    public static void iteratingtoInput()
    {
        Console.Write("Give a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int i = 0;

        while (i <= input)
        {
            Console.WriteLine(i);
            i++;
        }

    }

    public static void numbersAndCalculations()
    {
        double total = 0;

        Console.Write("Give a number: ");
        double input = Convert.ToInt32(Console.ReadLine());
        double sum = input;

        while (input != -1)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            total++;

            if (input > 0)
            {
                sum = sum + input;
                Console.WriteLine(sum);

            }
            else
            {
                sum = sum - input;
            }
        }
        double average = sum / total;

        Console.WriteLine("Thx! Bye!");
        Console.WriteLine(sum);
        Console.WriteLine(average);


    }

    public static void bossBaby()
    {
        double total = 0;

        Console.Write("Give a number: ");
        double input = Convert.ToInt32(Console.ReadLine());
        double sum = input;
        double count = 0;
        int even = 0;
        int odd = 0;

        while (input != -1)
        {
            Console.Write("Give a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            total++;
            count++;


            if (input == -1)
            {
                sum = sum + input;

            }
            else
            {
                sum = sum - input;

                if (input % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
        }
        double average = sum / total;

        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Numbers before correct awnser: " + count);
        Console.WriteLine("Total: " + sum);
        Console.WriteLine("average: " + average);
        Console.WriteLine("even: " + even);
        Console.WriteLine("odd: " + odd);

    }

    public static void printPhrase()
    {
        Console.WriteLine("In a hole in the ground there lived a method.");
    }

    public static void printPhraseAmount()
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
            number--;
        }

    }

    public static void printUntilNumber()
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());

        while (number > -1)
        {
            Console.WriteLine(number);
            number--;
        }

    }

    public static void printUntilOne()
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }

    public static void division()
    {
        Console.Write("Give the first number: ");
        double num1 = int.Parse(Console.ReadLine());
        Console.Write("Give the second number: ");
        double num2 = int.Parse(Console.ReadLine());

        double sum3 = num1 / num2;
        Console.WriteLine(sum3);
    }

    public static void divisbleInRange()
    {
        Console.Write("Give the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Give the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        for (int num3 = num1; num3 < num2; num3++)
        {
            if (num3 % 3 == 0)
            {
                Console.WriteLine(num3);
            }

        }

    }

}