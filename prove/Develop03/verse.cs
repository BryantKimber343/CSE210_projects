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
    }

    public bool IsFinished()
    {
        int hiddenCount = 0;
        foreach (Word word in _verse)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }
        if (hiddenCount == _verse.Count)
        {
            return true;
        }
        return false;
    }

    public void HideWords()
    {
        Random random = new Random();
        int index = random.Next(0, _verse.Count);
        _verse[index].HideWord();
        
    }
}
