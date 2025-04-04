/*
CLASS Outdoor: Event
Variables:
_weather: string
Methods:
Outdoor(): base(): void
Outdoor(weather): base(title, description, date, time, address): void
ShortDisplay(): void
FullDisplay(): void
*/

public class Outdoor : Event
{
    private string _weather;

    public Outdoor() : base()
    {
        _weather = "No weather";
    }

    public Outdoor(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void ShortDisplay()
    {
        Console.WriteLine("Outdoor Event:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine("Date: " + _date);
    }

    public override void FullDisplay()
    {
        base.FullDisplay();
        Console.WriteLine($"Predicted Weather conditions on {_date}: {_weather}");
    }
}