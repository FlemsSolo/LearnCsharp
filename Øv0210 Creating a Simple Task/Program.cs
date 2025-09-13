Task myTask = Task.Run(() =>
{
    Console.WriteLine("Task Started");
    Task.Delay(3000).Wait(); // Simulate work
    Console.WriteLine("Task Completed");
});

myTask.Wait();