/*
CLASS Cycling: Activity
Variables:
_speed: double
Methods:
GetDistance(): double
GetSpeed(): double
GetPace(): double
DisplaySummary(): void
*/

public class Cycling : Activity
{
    private double _speed;

    public Cycling() : base()
    {
        _speed = 0.0;
    }
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(_speed * _duration / 60, 2);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
    public override double GetPaceKm()
    {
        return Math.Round(60 / (_speed * 1.609),2); 
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Cycling ({_duration})- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile");
        Console.WriteLine($"{_date} Cycling ({_duration})- Distance: {Math.Round(GetDistance() * 1.609, 2)} kilometers, Speed: {Math.Round(GetSpeed() * 1.609, 2)} kph, Pace: {GetPaceKm()} min/kilometer");
    }
}