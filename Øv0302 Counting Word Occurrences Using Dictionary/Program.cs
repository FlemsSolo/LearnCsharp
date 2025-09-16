using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Ask the user to input a sentence
        //Console.Write("Enter a sentence: ");
        //string input = Console.ReadLine();
        string input =
            "Mary had a little lamb and everywhere that Mary went the lamb was sure to follow ø ø ø" ;
        
        // Step 2: Split the sentence into words
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Step 3: Create a Dictionary to count word occurrences
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        
        // Step 4: Count each word's occurrences
        foreach (string word in words)
        {
            string lowerWord = word.ToLower();
            if (wordCounts.ContainsKey(lowerWord))
            {
                wordCounts[lowerWord]++;
            }
            else
            {
                wordCounts[lowerWord] = 1;
            }
        }
        
        // Step 5: Display each word and its count
        Console.WriteLine("Word counts:");
        foreach (var kvp in wordCounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}