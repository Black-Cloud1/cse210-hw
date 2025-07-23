using System;

public class Word
{
    // Member variables
    private string _text;
    private bool _isHidden;

    // Constuctor 
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    // Define behaviors
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}