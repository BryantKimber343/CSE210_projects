public class Comment
{
    private string _text;
    private string _author;

    public Comment()
    {
        _text = "";
        _author = "";
    }
    public Comment(string author, string text)
    {
        _text = text;
        _author = author;
    }
    public void Display()
    {
        Console.WriteLine($"Comment by {_author}: {_text}");
    }
}