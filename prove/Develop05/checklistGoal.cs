
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _repetitions;
    private bool _isCompleted;
    private int _bonusPoints;
    private int _timeFrame;

    public ChecklistGoal()
    {
        _timesCompleted = 0;
        _repetitions = 1;
    }
    public ChecklistGoal(int pointValue, string description, int reps, int bonus, int timesCompleted,bool isCompleted, int timeFrame): base(pointValue, description)
    {
        _repetitions = reps;
        _bonusPoints = bonus;
        _timesCompleted = timesCompleted;
        _isCompleted = isCompleted;
        _timeFrame = timeFrame;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_description} [{_timesCompleted}/{_repetitions}], deadline: {_timeFrame} weeks");
    }

        public override int CompleteGoal()
    {
        _timesCompleted++;
        if (_timesCompleted >= _repetitions)
        {
            _isCompleted = true;
            return _pointValue + _bonusPoints;
        }
        return _pointValue;
    }

    public override void SaveGoal(StreamWriter outputFile)
    { 
       outputFile.WriteLine(_description + "~" + _pointValue + "~" + _repetitions + "~" + _timesCompleted + "~" + _bonusPoints + "~" + _isCompleted + "~" + _timeFrame);   
    }
    public override void EditGoal(string description, int pointValue)
    {
        Console.WriteLine("How many times would you like to complete this goal? ");
        int repetitions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points would you like to this goal to be worth? ");
        int bonus = int.Parse(Console.ReadLine());
        Console.WriteLine("How many weeks do you have to complete this goal? ");
        int timeFrame = int.Parse(Console.ReadLine());
        _timesCompleted = 0;
        _isCompleted = false;
        _repetitions = repetitions;
        _bonusPoints = bonus;
        _timeFrame = timeFrame;
        _description = description;
        _pointValue = pointValue;
    }
}