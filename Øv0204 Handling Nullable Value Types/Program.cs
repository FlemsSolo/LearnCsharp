int? userAge = null;
Console.Write("Enter your age: ");
string input = Console.ReadLine();
Console.WriteLine($"input: '{input}'");
if (int.TryParse(input, out int age))
{
    userAge = age;
}
Console.WriteLine($"Your age is: {userAge ?? 18}");