using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskItem(int id, string title, bool isCompleted)
    {
        Id = id;
        Title = title;
        IsCompleted = isCompleted;
    }
}

class Program
{
    static void Main()
    {
        string filePath = "tasks.json";

        // Step 2: Create a list of tasks
        List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem(1, "Complete C# project", false),
            new TaskItem(2, "Read documentation", true),
            new TaskItem(3, "Submit assignment", false)
        };

        // Step 3: Serialize the list of tasks to JSON and save it to a file
        SaveTasksToFile(tasks, filePath);

        // Step 4: Read and deserialize tasks from the file
        List<TaskItem> loadedTasks = LoadTasksFromFile(filePath);

        // Step 5: Display the tasks loaded from the file
        Console.WriteLine("\nTasks Loaded from File:");
        DisplayTasks(loadedTasks);

        // Step 6: Add a new task, update the file, and display the updated tasks
        TaskItem newTask = new TaskItem(4, "Review code", false);
        loadedTasks.Add(newTask);
        SaveTasksToFile(loadedTasks, filePath);
        
        Console.WriteLine("\nUpdated Tasks:");
        DisplayTasks(loadedTasks);
    }

    // Method to save tasks to a file
    static void SaveTasksToFile(List<TaskItem> tasks, string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(tasks, options);
        File.WriteAllText(filePath, json);
        Console.WriteLine($"\nTasks saved to {filePath}.");
    }

    // Method to load tasks from a file
    static List<TaskItem> LoadTasksFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found, creating a new task list.");
            return new List<TaskItem>();
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
    }

    // Method to display tasks
    static void DisplayTasks(List<TaskItem> tasks)
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Completed: {task.IsCompleted}");
        }
    }
}