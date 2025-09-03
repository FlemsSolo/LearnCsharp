using System;

namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringManipulator stringManipulator = new StringManipulator();
            
            stringManipulator.MakeABBA("A", "B");
            stringManipulator.MakeABBA("Hi", "Bye");
            stringManipulator.MakeABBA("Alice", "Bob");

            Console.WriteLine($"Result: {stringManipulator.MakeWord("<<>>", "test")}");
        }
    }
}