/*
CLASS Lecture: Event
Variables:
_speaker: string
_capacity: int
Methods:
Lecture(): base(): void
Lecture(speaker, capacity): base(title, description, date, time, address): void
ShortDisplay(): void
FullDisplay(): void
*/

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture() : base()
    {
        _speaker = "No speaker";
        _capacity = 0;
    }

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void ShortDisplay()
    {
        Console.WriteLine("Lecture Event:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine("Date: " + _date);
    }

    public override void FullDisplay()
    {
        base.FullDisplay();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}