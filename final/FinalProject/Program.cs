using System;

public enum Priority
{
    Low,
    Medium,
    High
}



class Program
{
    static void Main(string[] args)
    {
        // Testing Task class
        Task task1 = new Task("Complete project", "Finish the coding project", DateTime.Now.AddDays(7), Priority.High, "Coding");
        Task task2 = new Task("Study for exam", "Prepare for the upcoming exam", DateTime.Now.AddDays(5), Priority.Medium, "Study");
        
        Console.WriteLine(task1);
        Console.WriteLine(task2);

        // Mark task1 as complete and print again
        task1.MarkAsComplete();
        Console.WriteLine(task1);
    }
}
