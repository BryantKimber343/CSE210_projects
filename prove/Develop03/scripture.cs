class Scripture
{
   private List<Verse> _verses;
   private string _reference;
   public Scripture()
   {
       _verses = new List<Verse>();
   }
   public Scripture(string text, string reference)
   {
       _verses = new List<Verse>();
       _reference = reference;
       string[] verses = text.Split('\n');
       foreach (string verse in verses)
       {
           _verses.Add(new Verse(verse));
       }
   }
    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Verse verse in _verses)
         {
              verse.Display();
         }
    }
    public bool IsFinished()
    {
         foreach (Verse verse in _verses)
         {
            int doneVerse = 0;
              if (verse.IsFinished())
              {
                     doneVerse++;
              }
                if (doneVerse == _verses.Count)
                {
                     return true;
                }
              
         }
         return false;
    }

    public void HideWords()
    {
         if (!IsFinished())
         {
              Random random = new Random();
              int index = random.Next(0, _verses.Count);
              _verses[index].HideWords();
         }
    }

}