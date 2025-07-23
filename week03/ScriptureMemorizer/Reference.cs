using System;

public class Reference
{
    // Member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    // Constructor
    public Reference(string book, int chapter, int verse)
    {
        // Attributes
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // Attributes
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endverse = endVerse;
    }
    // Methods
    public string GetDisplayText()
    {
        if (_endverse == 0 || _endverse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
    }
}