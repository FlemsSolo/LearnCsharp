Task<int> sumTask = Task.Run(() =>
{
    Task.Delay(2000).Wait(); // Simulate work
    return 5 + 7;
});

Console.WriteLine("Task Is Waiting !");

int result = sumTask.Result;
Console.WriteLine($"Sum: {result}");