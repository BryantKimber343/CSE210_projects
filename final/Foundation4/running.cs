/*
CLASS Running: Activity
Variables:
_distance: double
Methods:
GetDistance(): double
GetSpeed(): double
GetPace(): double
DisplaySummary(): void
*/

public class Running : Activity
{
    private double _distance;

    public Running() : base()
    {
        _distance = 0.0;
    }
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round(_distance / _duration * 60, 2);
    }
    public override double GetPace()
    {
        return Math.Round(_duration / _distance, 2);
    }
    public override double GetPaceKm()
    {
        return Math.Round(_duration / (_distance * 1.609), 2);
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Running ({_duration})- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile");
        Console.WriteLine($"{_date} Running ({_duration})- Distance: {Math.Round(GetDistance() * 1.609, 2)} kilometers, Speed: {Math.Round(GetSpeed() * 1.609, 2)} kph, Pace: {GetPaceKm()} min/kilometer");
    }
}