
public class SimpleGoal : Goal
{
    private bool _isCompleted;
    private int _timeFrame;
    public SimpleGoal()
    {
        
    }
    public SimpleGoal(int pointValue, string description, bool isCompleted, int timeFrame) : base(pointValue, description)
    {
        _isCompleted = isCompleted;
        _timeFrame = timeFrame;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_description}, deadline: {_timeFrame} weeks");
    }
    public override int CompleteGoal()
    {
        _isCompleted = true;
        return _pointValue;
    }

    public override void SaveGoal(StreamWriter outputFile)
    {
        outputFile.WriteLine(_description + "~" + _pointValue + "~" + _isCompleted + "~" + _timeFrame);
    }

    public override void EditGoal(string description, int pointValue)
    {
        Console.WriteLine("How many weeks do you have to complete this goal? ");
        int timeFrame = int.Parse(Console.ReadLine());
        _timeFrame = timeFrame;
        _description = description;
        _pointValue = pointValue;
        _isCompleted = false;
    }
}