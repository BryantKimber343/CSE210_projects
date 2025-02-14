class Word
{
    private string _word ;
    private bool _isHidden;

    public Word()
    {
        _word = "";
        _isHidden = false;
    }
    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }
    public void SetHidden(bool isHidden)
    {
        _isHidden = isHidden;
    } 
    public void Display()
    {
        Console.Write(_word + " ");
    }
    public void HideWord()
    {
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
    }
}