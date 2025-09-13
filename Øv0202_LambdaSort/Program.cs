List<string> names = new List<string> { "Alice", "Bob", "Christopher", "David", "Eve" };

// Sorting names by length in descending order using a lambda expression
names.Sort((name1, name2) => name2.Length.CompareTo(name1.Length));

Console.WriteLine("Sorted names by length (descending):");
foreach (var name in names)
{
    Console.WriteLine(name);
}