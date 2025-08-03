using System.Runtime.Intrinsics.X86;

class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This Activity will help you reflect on the good things in your life by having you list as many things you can in a certain area.";
        _prompts = new List<string> { "When have you felt the Holy Ghost this Month?", "Who are people you appreciate?", "What are your personal strengths?", "What are you grateful today?" };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nList as many resposes you can to the following prompt:");
        Console.WriteLine($"  --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        List<string> listItems = GetListFromUser();
        _count = listItems.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }
        return responses;
    }
}