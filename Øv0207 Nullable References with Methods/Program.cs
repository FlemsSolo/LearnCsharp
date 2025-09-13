class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
}

internal class Program
{
    public static void Main(string[] args)
    {
        string? GetTitle(Book? book)
        {
            return book?.Title;
        }

        string? GetAuthor(Book? book)
        {
            return book?.Author;
        }

        Book? book1 = new Book { Title = "1984", Author = "George Orwell" };
        Book? book2 = new Book { Title = "Book No Author", Author = null };
        Book? book3 = null;

        Console.WriteLine(GetTitle(book1) ?? "None");
        Console.WriteLine(GetAuthor(book1) ?? "No author provided");
        Console.WriteLine(GetTitle(book2) ?? "None");
        Console.WriteLine(GetAuthor(book2) ?? "No author provided");
        Console.WriteLine(GetTitle(book3) ?? "None");
        Console.WriteLine(GetAuthor(book3) ?? "No book provided");
    }
}