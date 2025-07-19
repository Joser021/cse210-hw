using System.Runtime.InteropServices;

public class Scripture
{
    Reference _reference;
    List<Word> _words;

    // removes spaces around each word and add to the list
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // hides the word in the text
    public void HideRandomWords(int numberToHide)
    {
        List<Word> showedWords = _words.Where(word => !word.IsHidden()).ToList();
        Random random = new Random();

        int hiddenWords = Math.Min(numberToHide, showedWords.Count);

        for (int i = 0; i < hiddenWords; i++)
        {
            int index = random.Next(showedWords.Count);
            showedWords[index].Hide();
            showedWords.RemoveAt(index);
        }
    }

    // displays the scripture
    public string GetDisplayText()
    {
        var displayWord = _words.Select(word => word.GetDisplayText());
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWord)}";
    }

    // check is the text is completly hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}