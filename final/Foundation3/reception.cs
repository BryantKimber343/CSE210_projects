/*
CLASS Reception: Event
Variables:
_email
Methods:
Reception(): base(): void
Reception(email): base(title, description, date, time, address): void
ShortDisplay(): void
FullDisplay(): void
*/
public class Reception : Event
{
    private string _email;

    public Reception() : base()
    {
        _email = "No email";
    }

    public Reception(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void ShortDisplay()
    {
        Console.WriteLine("Reception Event:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine("Date: " + _date);
    }

    public override void FullDisplay()
    {
        base.FullDisplay();
        Console.WriteLine($"Email: {_email}");
    }
}