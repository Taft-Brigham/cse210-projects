class ListingActivity : Activity
{
    private List<string> _prompts;
    private string _logFilePath = "activity_log.txt"; // Path to the log file

    public ListingActivity(string name, string description, int duration, List<string> prompts)
        : base(name, description, duration)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Starting listing activity...");

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        Console.WriteLine("List as many items as you can:");
        Console.WriteLine("(Press enter after each item)");

        int count = 0;
        List<string> itemsListed = new List<string>(); // To store the listed items

        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;
            count++;
            itemsListed.Add(item); // Add the item to the list
        }

        Console.WriteLine($"Total items listed: {count}");

        // Log the listed items to the file
        LogItems(itemsListed);

        DisplayEndingMessage();
    }

    private void LogItems(List<string> itemsListed)
    {
        using (StreamWriter writer = new StreamWriter(_logFilePath, true)) // Append mode
        {
            writer.WriteLine($"Activity: {_name}");
            writer.WriteLine($"Date and Time: {DateTime.Now}");
            writer.WriteLine("Listed Items:");
            foreach (string item in itemsListed)
            {
                writer.WriteLine(item);
            }
            writer.WriteLine("----------------------------------");
        }
        Console.WriteLine("Items listed have been logged.");
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}