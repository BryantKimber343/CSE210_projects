class Scripture
{
    private List<Verse> _scripture;
    private string _reference;
    public Scripture()
    {
        _scripture = new List<Verse>();
    }
    public Scripture(string text, string reference)
    {
        reference = _reference;
        _scripture = new List<Verse>();
        string[] verses = text.Split('\n');
        foreach (string verse in verses)
        {
            _scripture.Add(new Verse(verse));
        }
    }
    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Verse verse in _scripture)
        {
            verse.Display();
        }
    }
    public void HideWord()
    {
        
        Random random = new Random();
        int index = random.Next(0, _scripture.Count);
        while (_scripture[index].IsFinished())
        {
            index = random.Next(0, _scripture.Count);
        }
        _scripture[index].HideWord();
        
    }
    public bool IsFinished()
    {
        int finishedVerse = 0;
        int verseNum = _scripture.Count();
        foreach (Verse verse in _scripture)
        {
            if (verse.IsFinished())
            {
                finishedVerse++;
            }
        }
        if (finishedVerse == verseNum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}