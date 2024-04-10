class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3); // Pause for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations! You've completed the activity.");
        Console.WriteLine($"You've done a good job with the {_name} activity.");
        ShowSpinner(5); // Pause for 5 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        Console.Write("Processing ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000); // Pause for 1 second
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop); // Move cursor back two characters
            Console.Write("  "); // Erase the last number displayed
            Thread.Sleep(500); // Pause for half a second
        }
        Console.WriteLine("Go!"); // Display "Go!" after countdown
    }
}