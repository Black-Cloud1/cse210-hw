
using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string _date;

    public string _promptText;
    public string _entryText;

    public Entry(string date, string promt, string response)
    {
        _date = date;
        _promptText = promt;
        _entryText = response;
    }
    //
    public string GetFormattedEntry()
    {
        return $"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n";
    }

    public string GetSerializedEntry()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
    //
    public static Entry FromSerializedEntry(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }


}