using System;

namespace Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumberWriter numberWriter = new NumberWriter();

            numberWriter.PrintEvenNumbersFromZeroToX(10);
            numberWriter.PrintOddNumbersFromZeroToX(10);
            numberWriter.PrintNumbersFromZeroToXDivisibleByY(10, 3);
        }
    }
}