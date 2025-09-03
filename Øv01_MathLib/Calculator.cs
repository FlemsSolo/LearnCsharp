namespace MathLib;

public class Calculator
{
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded function
        public int Add(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        public void ReadTwoIntegersAndPrintTheHighest()
        {
            Console.WriteLine("Enter the first number: ");
            string firstNumberAsString = Console.ReadLine();
            int firstNumberAsInt = Convert.ToInt32(firstNumberAsString);

            Console.WriteLine("Enter the second number: ");
            string secondNumberAsString = Console.ReadLine();
            int secondNumberAsInt = Convert.ToInt32(secondNumberAsString);

            Console.WriteLine($"The highest numbers is: {Math.Max(firstNumberAsInt, secondNumberAsInt)}");
        }    }
