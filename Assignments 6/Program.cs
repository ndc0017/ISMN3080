using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Question1("Natalie"); 
            Console.WriteLine();

            // Question 2
            int numA = 10;
            int numB = 40;
            int largerValue = Question2(numA, numB);
            Console.WriteLine("Numbers: " + numA + " and " + numB);
            Console.WriteLine("Larger: " + largerValue);
            Console.WriteLine();

            // Question 3
            int startPoint = 1;
            int endPoint = 10;
            int countResult = Question3(startPoint, endPoint);
            Console.WriteLine("Range: " + startPoint + " and " + endPoint);
            Console.WriteLine("Count: " + countResult);
            Console.WriteLine();

            // Question 4
            string gradeString = "88.5";
            bool isPassing = Question4(gradeString);
            Console.WriteLine("Grade Entered: " + gradeString);
            if (isPassing == true)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
            Console.WriteLine();

            // Question 5
            int val1 = 1;
            int val2 = 2;
            int val3 = 2;
            decimal averageResult = Question5(val1, val2, val3);
            Console.WriteLine("Numbers: " + val1 + ", " + val2 + ", " + val3);
            Console.WriteLine("Average: " + averageResult);
        }

        static void Question1(string name)
        {
            Console.WriteLine($"Hello {name}, Let’s make some functions!");
        }

        static int Question2(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else if (second > first)
            {
                return second;
            }
            else
            {
                return first;
            }
        }

        static int Question3(int start, int end)
        {
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                counter = counter + 1;
            }
            return counter;
        }

        static bool Question4(string gradeInput)
        {
            decimal numericGrade;
            bool canConvert = decimal.TryParse(gradeInput, out numericGrade);

            if (canConvert == true && numericGrade >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static decimal Question5(int a, int b, int c)
        {
            decimal total = (decimal)a + (decimal)b + (decimal)c;
            decimal average = total / 3;
            return average;
        }
    }
}