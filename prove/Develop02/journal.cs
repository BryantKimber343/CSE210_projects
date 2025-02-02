
/*
    properties:
        - entries: List<Entry>
        - changed: boolean
    methods:
        - addEntry(): void
        - loadEntries(): void
        - saveEntries(): void
*/

using System.Collections.Concurrent;
using System.IO;
public class Journal
{
    public bool _changed = false;
    public bool _loaded = false;

    public List<Entry> _entries = new List<Entry>();
    public void addEntry()
    {
        Entry entry = new Entry();
        entry._prompt = new PromptManager().getPrompt();
        Console.WriteLine("First, what's one word to describe how you're feeling today?");
        entry._feeling = Console.ReadLine();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        _entries.Add(entry);
        _changed = true;
    }
    
    public void loadEntries()
    {
        string filename = "journalbook.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 5)
        {
            Entry entry = new Entry();
            entry._dateAndTime = lines[i];
            entry._prompt = lines[i + 1];
            entry._response = lines[i + 2];
            entry._feeling = lines[i + 3];
            _entries.Add(entry);
        }
        _loaded = true;

    }

    public void saveEntries()
    {
        string fileName = "journalbook.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, false))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._dateAndTime);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
                outputFile.WriteLine("Feeling: "+entry._feeling);
                outputFile.WriteLine();
            }
        }
        _changed = false;
    }

    public void displayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.displayEntry();
        }
    }
}