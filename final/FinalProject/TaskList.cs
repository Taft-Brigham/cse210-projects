public class TaskList
{
    private List<Task> tasks;

    public TaskList()
    {
        tasks = new List<Task>();
    }

    // Method to add a task
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    // Method to remove a task
    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
    }

    // Method to update a task
    public void UpdateTask(Task task)
    {
        // You can implement the logic for updating a task here
    }

    // Method to get all tasks
    public List<Task> GetAllTasks()
    {
        return tasks;
    }
}