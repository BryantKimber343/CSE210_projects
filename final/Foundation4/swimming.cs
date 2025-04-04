/*
CLASS Swimming: Activity
Variables:
lapNum: int
Methods:
GetDistance(): double
GetSpeed(): double
GetPace(): double
DisplaySummary(): void
*/

public class Swimming: Activity
{
    private int _lapNum;
    private double _lapLength = 50.0; // in meters

    public Swimming() : base()
    {
        _lapNum = 0;
    }
    public Swimming(string date, int duration, int lapNum) : base(date, duration)
    {
        _lapNum = lapNum;
    }
    public override double GetDistance()
    {
        return _lapNum * _lapLength / 1000; // convert to kilometers
    }
    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / (_duration / 60.0), 2); // convert to minutes
    }
    public override double GetPace()
    {
        return Math.Round(_duration / GetDistance(), 2); // pace in minutes per kilometer
    }
    public override double GetPaceKm()
    {
        return Math.Round(_duration / (GetDistance() * 1.609), 2);
    }

     public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Swimming ({_duration})- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile");
        Console.WriteLine($"{_date} Swimming ({_duration})- Distance: {Math.Round(GetDistance() * 1.609, 2)} kilometers, Speed: {Math.Round(GetSpeed() * 1.609, 2)} kph, Pace: {GetPaceKm()} min/kilometer");    }

}