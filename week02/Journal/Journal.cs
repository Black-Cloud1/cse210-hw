using System;
using System.IO;

//methods
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetFormattedEntry());
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetSerializedEntry());
            }
        }
    }
    public void LoadFromFile(string filename = "")
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromSerializedEntry(line));
        }
    }
}