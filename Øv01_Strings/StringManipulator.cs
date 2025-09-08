using System;

namespace Strings
{
    public class StringManipulator
    {
        public void MakeABBA(string a, string b)
        {
            Console.WriteLine($"{a}{b}{b}{a}");
        }
        
        public string MakeWord(string outer, string word)
        {
            return $"{outer.Substring(0, 2)}{word}{outer.Substring(2)}";
        }    
    }
}