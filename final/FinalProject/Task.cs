public class Task
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public DateTime Deadline { get; private set; }
    public Priority Priority { get; private set; }
    public bool IsComplete { get; private set; }
    public string Project { get; private set; }

    // Constructor
    public Task(string name, string description, DateTime deadline, Priority priority, string project)
    {
        Name = name;
        Description = description;
        Deadline = deadline;
        Priority = priority;
        IsComplete = false; // By default, task is not complete
        Project = project;
    }

    // Method to mark the task as complete
    public void MarkAsComplete()
    {
        IsComplete = true;
    }

    // Override ToString for better printing
    public override string ToString()
    {
        string completionStatus = IsComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {Name} | Deadline: {Deadline.ToShortDateString()} | Priority: {Priority} | Project: {Project}";
    }
}