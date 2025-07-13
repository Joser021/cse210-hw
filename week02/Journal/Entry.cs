public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _response { get; set; }

    public Entry(string prompt, string answer)
    {
        _date = DateTime.Now.ToString("dd-MM-yyyy");
        _promptText = prompt;
        _response = answer;
    }
    public void Display()
    {
        Console.WriteLine($@"
Date: {_date} - Prompt: {_promptText}
{_response}
        ");
    }
}