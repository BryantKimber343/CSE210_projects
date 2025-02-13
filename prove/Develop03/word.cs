class Word
{
    private string _word;
    private bool _hidden;

    public Word()
    {
        _word = "";
        _hidden = false;
    }

    public Word(string text, bool hidden)
    {
        _word = text;
        _hidden = hidden;
    }

    public void Display()
    {
        Console.Write(_word + " ");
    }

    public bool IsHidden()
    {
        foreach (char c in _word)
        {
            if (c == '_')
            {
                return true;
            }
        }
        return false;
    }

    public void HideWord()
    {

        int length = _word.Length;
        string hiddenWord = "";
        for (int i = 0; i < length; i++)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
    }
}