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

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}");
                writer.WriteLine($"{entry._promptText}");
                writer.WriteLine($"{entry._response}");
            }
        }
        Console.WriteLine($"Entries sucessfully saved to {file}!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File no found!");
        }

        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            Entry currentEntry = null;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date:"))
                {
                    if (currentEntry != null)
                    {
                        _entries.Add(currentEntry);
                    }

                    string date = line.Substring(6).Trim();
                    currentEntry = new Entry(string.Empty, string.Empty) { _date = date };
                }
                else if (line.StartsWith("Prompt:"))
                {
                    currentEntry._promptText = line.Substring(8).Trim();
                }
                else if (line.StartsWith("Response:"))
                {
                    currentEntry._response = line.Substring(10).Trim();
                }
                else if (string.IsNullOrWhiteSpace(line) && currentEntry != null)
                {
                    _entries.Add(currentEntry);
                    currentEntry = null;
                }
            }

            if (currentEntry != null)
            {
                _entries.Add(currentEntry);
            }
        }
    }
}