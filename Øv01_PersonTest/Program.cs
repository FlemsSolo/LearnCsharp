using System;

namespace PersonTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Using constructor
            Person person1 = new Person("Alice");
            person1.Introduce();

            //Using object initializer
            Person person2 = new Person{Name = "Bob"};
            person2.Introduce();
        }
    }
}