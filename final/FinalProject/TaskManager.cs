public class TaskManager
{
    private TaskList taskList;

    public TaskManager()
    {
        taskList = new TaskList();
    }

    // Method to display all tasks
    public void DisplayTasks()
    {
        List<Task> tasks = taskList.GetAllTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }

    // Method to add a new task
    public void AddTask()
    {
        Console.Write("Enter task name: ");
        string name = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        Console.Write("Enter task deadline (MM/dd/yyyy): ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter task priority (Low/Medium/High): ");
        Priority priority = (Priority)Enum.Parse(typeof(Priority), Console.ReadLine(), true);
        Console.Write("Enter project name: ");
        string project = Console.ReadLine();

        Task task = new Task(name, description, deadline, priority, project);
        taskList.AddTask(task);
        Console.WriteLine("Task added successfully.");
    }

    // Method to mark a task as complete
    public void MarkTaskAsComplete()
    {
        Console.Write("Enter the index of the task to mark as complete: ");
        int index = int.Parse(Console.ReadLine()) - 1; // Subtract 1 as the index is 1-based
        List<Task> tasks = taskList.GetAllTasks();
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].MarkAsComplete();
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    // Method to save tasks to a file
    public void SaveTasks()
    {
        List<Task> tasks = taskList.GetAllTasks();
        Console.Write("Enter the name of the file to save tasks: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Task task in tasks)
            {
                writer.WriteLine($"{task.Name},{task.Description},{task.Deadline},{task.Priority},{task.IsComplete},{task.Project}");
            }
        }
        Console.WriteLine("Tasks saved successfully.");
    }

    // Method to load tasks from a file
    public void LoadTasks()
    {
        Console.Write("Enter the name of the file to load tasks from: ");
        string fileName = Console.ReadLine();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string description = parts[1];
                DateTime deadline = DateTime.Parse(parts[2]);
                Priority priority = (Priority)Enum.Parse(typeof(Priority), parts[3], true);
                bool isComplete = bool.Parse(parts[4]);
                string project = parts[5];
                Task task = new Task(name, description, deadline, priority, project);
                if (isComplete)
                {
                    task.MarkAsComplete();
                }
                taskList.AddTask(task);
            }
        }
        Console.WriteLine("Tasks loaded successfully.");
    }
}
