/*
attributes:
_references: string

methods:
Reference() void
Reference(book, chapter, verse) void
Reference(book, chapter, startVerse, endVerse) void
*/

class Reference
{
    private string _references;

    public Reference()
    {
        _references = "";
    }

    public Reference(string book, int chapter, int verse)
    {
        _references = book + " " + chapter + ":" + verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _references = book + " " + chapter + ":" + startVerse + "-" + endVerse;
    }

    public void Display()
    {
        Console.WriteLine(_references);
    }
}
