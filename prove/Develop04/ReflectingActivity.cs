class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run(int reflectionDuration)
    {
        DisplayStartingMessage();
        Console.WriteLine($"This reflecting activity will last for {reflectionDuration} seconds.");

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        foreach (string question in _questions)
        {
            Console.WriteLine($"Question: {question}");
            Console.ReadLine(); // Wait for user to press enter before showing next question
            Console.WriteLine("Thinking...");
            Thread.Sleep(2000); // Pause for 2 seconds to simulate thinking
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}