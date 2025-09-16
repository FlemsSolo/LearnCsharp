using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Step 1: Create a List of student names
        List<string> studentNames = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Ært", "Øl", "Ål", "Eve" };
        
        // Step 2: Display the original list
        Console.WriteLine("Original List: " + string.Join(", ", studentNames));
        
        // Step 3: Ask the user to input a name and add it to the list
        //Console.Write("Enter a name to add: ");
        //string newName = Console.ReadLine();
        //studentNames.Add(newName);
        
        // Step 4: Sort the list alphabetically and display it
        studentNames.Sort();
        Console.WriteLine("Sorted List: " + string.Join(", ", studentNames));
        
        // If you need to sort based on UTF-8 byte values
        studentNames.Sort((x, y) => CompareUtf8(x, y));
        Console.WriteLine("Sorted List (UTF8) : " + string.Join(", ", studentNames));
        
        // Sort the list using Danish culture
        studentNames.Sort(StringComparer.Create(new CultureInfo("da-DK"), true));
        Console.WriteLine("Sorted List (Cult.) : " + string.Join(", ", studentNames));

        // Step 5: Remove a specific name ("Bob") and display the updated list
        studentNames.Remove("Bob");
        Console.WriteLine("List after removing 'Bob': " + string.Join(", ", studentNames));
    }
    
   static int CompareUtf8(string x, string y)
    {
        byte[] xBytes = Encoding.UTF8.GetBytes(x);
        byte[] yBytes = Encoding.UTF8.GetBytes(y);
        return BitConverter.ToString(xBytes).CompareTo(BitConverter.ToString(yBytes));
    }
 
}