using Microsoft.VisualBasic;

class Timer
{
    private System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

    public void Start()
    {
        watch.Start();
    }

    public void Stop()
    {
        watch.Stop();
    }

    public double GetTimePassed()
    {
        double timePassed = watch.Elapsed.TotalSeconds;
        return timePassed;
    }
}