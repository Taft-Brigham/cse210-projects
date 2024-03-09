public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _additionalInfo;

    public Entry(string promptText, string entryText, string additionalInfo, string date)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _additionalInfo = additionalInfo;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Additional Info: {_additionalInfo}");
        Console.WriteLine();
    }

   public string GetFormattedEntryForCSV()
    {
        return $"{_date},{EscapeCSVString(_promptText)},{EscapeCSVString(_entryText)},{EscapeCSVString(_additionalInfo)}";
    }

    // Handling CSV string 
    private string EscapeCSVString(string value)
    {
        return $"\"{value.Replace("\"", "\"\"")}\"";
    }
}