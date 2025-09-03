using System;

namespace MathLib
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"Calling add with two numbers: {calculator.Add(2, 3)}");
            Console.WriteLine($"Calling add with an integer array: {calculator.Add(new int[]{1,2,3,4,5})}");

            calculator.ReadTwoIntegersAndPrintTheHighest();
        }
    }
}