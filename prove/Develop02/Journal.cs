using System.Xml.Linq;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToCSV(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry,AdditionalInfo");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetFormattedEntryForCSV());
            }
        }
        Console.WriteLine("Journal saved to CSV file successfully.");
    }

    public void LoadFromCSV(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            bool isFirstLine = true;
            while ((line = reader.ReadLine()) != null)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue; 
                }
                string[] parts = line.Split(',');
                _entries.Add(new Entry(parts[1], parts[2], parts[3], parts[0]));
            }
        }
        Console.WriteLine("Journal loaded from CSV file successfully.");
    }
}