class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public void Run(int breathingDuration)
    {
        DisplayStartingMessage();
        Console.WriteLine($"This breathing activity will last for {breathingDuration} seconds.");

        Console.WriteLine("Starting breathing activity...");

        for (int i = 0; i < _duration / (2 * breathingDuration); i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(breathingDuration);

            Console.WriteLine("Breathe out...");
            ShowCountdown(breathingDuration);
        }

        DisplayEndingMessage();
    }
}