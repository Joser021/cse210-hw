using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts;
    Random _randomIndex = new Random();

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the most meaningful moment of my day?",
            "If I could relive one moment from today, which would I choose and why?",
            "What challenged me today and how did I respond?",
            "What’s one small victory I had today?",
            "What drained my energy today—and was it worth it?",
            "How am I really feeling right now? Why?",
            "What’s something I’ve been avoiding, and why?",
            "What part of myself do I want to better understand?",
            "When do I feel most like me?",
            "What belief do I hold that may no longer be serving me?",
            "What’s something I learned about myself recently?",
            "In what ways have I grown in the past year?",
            "What’s one habit I’d like to build, and why?",
            "What does 'success' look like for me right now?",
            "If I met my younger self, what advice would I give them?",
            "What am I grateful for today, and why?",
            "Who made my day better today—and how?",
            "What’s one beautiful thing I noticed today?",
            "What’s a memory that always makes me smile?",
            "What’s something I take for granted that I want to appreciate more?",
            "If I could spend tomorrow doing anything, what would it be?",
            "What would my perfect day look like?",
            "If I could talk to one person (living or dead), who would it be and why?",
            "What story would I write if I had no fear?",
            "What’s a dream I haven’t let myself chase—yet?}"
        };
    }

        public string GetRandomPrompt()
        {
            int promptLength = _prompts.Count;
            int index = _randomIndex.Next(0, promptLength);

            return _prompts[index];
        }
}