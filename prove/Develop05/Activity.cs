using System;

public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    // Constructor to initialize Name and Description
    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {Name} activity!");
        Console.WriteLine($" {Description}");
        Console.WriteLine("Please enter the duration in seconds:");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed the {Name} activity.");
        Console.WriteLine($"Duration: {Duration} seconds.");
    }

    public virtual void ShowAnimation(string message, int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
             Console.Write(message);
             System.Threading.Thread.Sleep(500);// simulate animation with pause
             Console.Write("\b");// backspace to overwrite previous character
        }
        Console.WriteLine();
    }
    public abstract void Run();
}