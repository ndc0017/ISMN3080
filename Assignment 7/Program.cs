using System;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = -1;

            while (menuSelection != 0)
            {
                Console.WriteLine("1 - Question 1");
                Console.WriteLine("2 - Question 2");
                Console.WriteLine("3 - Question 3");
                Console.WriteLine("4 - Question 4");
                Console.WriteLine("0 - Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                // guard against null input and avoid stale menuSelection values
                if (string.IsNullOrWhiteSpace(input))
                {
                    menuSelection = -1;
                    Console.WriteLine("Invalid menu choice. Try again.");
                    continue;
                }

                if (int.TryParse(input, out menuSelection))
                {
                    if (menuSelection == 1)
                    {
                        Question1();
                    }
                    else if (menuSelection == 2)
                    {
                        Question2();
                    }
                    else if (menuSelection == 3)
                    {
                        Question3();
                    }
                    else if (menuSelection == 4)
                    {
                        Question4();
                    }
                    else if (menuSelection != 0)
                    {
                        Console.WriteLine("Invalid menu choice. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid menu choice. Try again.");
                }
            }
        }

        static void Question1()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        static void Question2()
        {
            int number;
            while (true)
            {
                Console.Write("Enter an integer: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                Console.WriteLine("Invalid integer. Try again.");
            }
            Console.WriteLine($"You entered: {number}");
        }

        static void Question3()
        {
            int num1, num2;
            while (true)
            {
                Console.Write("Enter the first integer: ");
                if (int.TryParse(Console.ReadLine(), out num1)) break;
                Console.WriteLine("Invalid integer. Try again.");
            }
            while (true)
            {
                Console.Write("Enter the second integer: ");
                if (int.TryParse(Console.ReadLine(), out num2)) break;
                Console.WriteLine("Invalid integer. Try again.");
            }
            Console.WriteLine($"Sum: {num1 + num2}");
        }

        static void Question4()
        {
            int count;
            while (true)
            {
                Console.Write("How many times should I print \"Hello\"? ");
                if (int.TryParse(Console.ReadLine(), out count))
                {
                    if (count > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Must be greater than 0. Try again.");
                }
                else
                {
                    Console.WriteLine("Invalid integer. Try again.");
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}