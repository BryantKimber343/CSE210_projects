/*
CLASS Activity
Variables:
_date: string
_duration: int
Methods:
GetDistance(): double
GetSpeed(): double
GetPace(): double
DisplaySummary(): void
*/

public abstract class Activity
{
    protected string _date;
    protected int _duration;

    public Activity()
    {
        _date = "";
        _duration = 0;
    }

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
    public abstract void DisplaySummary();
    public abstract double GetPaceKm();

}