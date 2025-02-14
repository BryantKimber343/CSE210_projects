class Verse
{
    private List<Word> _verse;
    
    public Verse()
    {
        _verse = new List<Word>();
    }
    public Verse(string text)
    {
        _verse = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _verse.Add(new Word(word, false));
        }
    }
    public void Display()
    {
        foreach (Word word in _verse)
        {
            word.Display();
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        Random random = new Random();
        int index = random.Next(0, _verse.Count);
        while (_verse[index].GetHidden() == true)
        {
            index = random.Next(0, _verse.Count);
        }
        _verse[index].HideWord();
        _verse[index].SetHidden(true);
    }
    public bool IsFinished()
    {
        int wordsNum = _verse.Count();
        int hiddenWords = 0;
        foreach (Word word in _verse)
        {
            if (word.GetHidden() == true)
            {
                hiddenWords++;
            }
        }
        if (hiddenWords == wordsNum)
        {
            return true;
        }
        else
        {
            return false;
        }   
    }

}