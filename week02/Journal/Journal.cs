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
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._promptText}");
                writer.WriteLine($"Response: {entry._response}");
                writer.WriteLine();
            }
        }
        Console.WriteLine($"Entries sucessfully saved to {file}!");
    }

public void LoadFromFile(string file)
{
    if (!File.Exists(file))
    {
        Console.WriteLine("File not found!");
        return;
    }

    _entries.Clear(); // Limpa as entradas existentes antes de carregar novas

    using (StreamReader reader = new StreamReader(file))
    {
        while (!reader.EndOfStream)
        {
            string dateLine = reader.ReadLine();
            string promptLine = reader.ReadLine();
            string responseLine = reader.ReadLine();
            reader.ReadLine(); // Lê a linha em branco de separação

            if (dateLine != null && promptLine != null && responseLine != null)
            {
                string date = dateLine.Replace("Date: ", "");
                string prompt = promptLine.Replace("Prompt: ", "");
                string response = responseLine.Replace("Response: ", "");

                Entry newEntry = new Entry(prompt, response)
                {
                    _date = date
                };
                _entries.Add(newEntry);
            }
        }
    }
    Console.WriteLine($"Entries successfully loaded from {file}!");
}
}

