using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            do
            {                
                Console.WriteLine("Please enter a number between 1 and 100: ");
                int num = int.Parse(Console.ReadLine());

                int numMax = 100;
                int numMin = 0;

                if (num > numMax)
                {
                    Console.WriteLine($"Your number must be less than 100");
                    Console.WriteLine();
                }
                else if (num < numMin)
                {
                    Console.WriteLine("Your number must be greater than 0");
                    Console.WriteLine();
                }
                else if (num % 2 == 1)
                {
                    Console.WriteLine($"{num} is an odd number");
                    Console.WriteLine();
                }
                else if (num > 2 && num <= 25 && num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number and less than 25");
                    Console.WriteLine();
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Please try again {name}");
                    Console.WriteLine();
                }

                bool ask = true;
                while (ask == true)
                {
                    Console.WriteLine("Would you like to enter another number? (Y/N)");
                    string response = Console.ReadLine().ToLower();

                    if (response == "n")
                    {
                        ask = false;
                        keepGoing = false;
                        Console.WriteLine($"Thank you {name}. Goodbye!");
                        break;
                    }
                    else if (response == "y")
                    {
                        ask = false;
                        keepGoing = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry {name}. I didn't catch that");
                        Console.WriteLine("Please try again");
                    }
                }
            } while (keepGoing);

        }

    }
}
