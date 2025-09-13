    class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name ?? "No Name"}");
            Console.WriteLine($"Age: {Age?.ToString() ?? "No Age"}");
        }
    }

        internal class Program
        {
            public static void Main(string[] args)
            {
                Person person1 = new Person { Name = "Alice", Age = 25 };
                Person person2 = new Person { Name = null, Age = null };

                person1.DisplayInfo();
                person2.DisplayInfo();
            }
        }
