
public class Goal
{
    protected int _pointValue;
    protected string _description;


    public Goal()
    {
        _pointValue = 0;
        _description = "";
        
    }
    public Goal(int pointValue, string description)
    {
        _pointValue = pointValue;
        _description = description;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_description}");
    }

    public virtual void SaveGoal(StreamWriter outputFile)
    {
        outputFile.WriteLine(_description + "~" + _pointValue);
    }

    public virtual int CompleteGoal()
    {
        return _pointValue;
    }

    public virtual void EditGoal(string description, int pointValue)
    {
        _description = description;
        _pointValue = pointValue;
    }

}