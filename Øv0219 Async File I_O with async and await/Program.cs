async Task<string> ReadFileAsync(string filePath)
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        Console.WriteLine("Simulating File Access ... \n");
        Task.Delay(2000).Wait(); // Simulate work
        return await reader.ReadToEndAsync();
    }
}

Console.WriteLine("Async FileRead Started ... ");

string content = await ReadFileAsync("example.txt");
Console.WriteLine($"Got : {content}");