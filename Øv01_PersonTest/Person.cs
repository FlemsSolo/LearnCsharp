namespace PersonTest
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}2");
        }
    }
}