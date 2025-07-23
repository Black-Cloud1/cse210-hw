
public class Scripture
{
    // Member variable
    private Reference _reference;
    private List<Word> _words;// List of word objects

    // Constructor
    public Scripture(Reference refernce, string text)
    {
        _reference = refernce;
        _words = new List<Word>();
        // Split up the words 
        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }
    // Method to call the random words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        Random random = new Random();
        int count = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + "\n\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}