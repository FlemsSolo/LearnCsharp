class Student
{
    public string? Name { get; set; }
    public string? Email { get; set; }
}


internal class Program
{
    public static void Main(string[] args)
    {
void SendEmail(Student student)
{
    if (student.Email == null)
    {
        Console.WriteLine("Email address not available.");
    }
    else
    {
        // Using null-forgiving operator
        Console.WriteLine($"Sending email to {student.Email!}");
    }
}

Student student1 = new Student { Name = "John", Email = null };
SendEmail(student1);
    }
}
