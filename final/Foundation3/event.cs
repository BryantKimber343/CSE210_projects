/*
CLASS Event
Variables:
_title: string
_description: string
_date: string
_time: string
_address: Address
Methods:
Event(): void
Event(title, description, date, time, address)
StandardDisplay(): void
FullDisplay(): void
ShortDisplay(): void
*/
public class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;

    public Event()
    {
        _title = "No title";
        _description = "No description";
        _date = "No date";
        _time = "No time";
        _address = new Address();
    }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public virtual void FullDisplay()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public virtual void ShortDisplay()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
    }
}