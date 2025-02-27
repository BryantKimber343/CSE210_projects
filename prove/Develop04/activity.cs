class Activity
{
    private string _type;
    private string _description;
    private int _duration;

    public Activity()
    {
        _type ="";
        _description = "";
        _duration = 0;
    }
    public Activity(string type, string description, int duration)
    {
        _type = type;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration()
    {
        Console.Write("How long would you like to do this activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }

    public void WelcomeDisplay()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_type} exercise.\n");
        Console.WriteLine(_description + "\n");
    }

    public void FinishDisplay()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"\nYou completed {_duration} seconds of the {_type} activity");
        Animation animation = new Animation();
        animation.WaitingAnimation(2);
            
    }
}