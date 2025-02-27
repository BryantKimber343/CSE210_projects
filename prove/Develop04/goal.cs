

class Goal : Activity
{
    Animation animation = new Animation();
    private string _broadGoal = "";
    private List<string> _dailyGoals = [];
    private int timeFrame = 0;

    public Goal() : base ("Goal Setting","This activity will help you set more acheivable goals and break down larger goals to a more managable size.",0)
    {

    }

    public void SetBroadGoal()
    {
        Console.Write("What is a big goal you have for the future: ");
        _broadGoal = Console.ReadLine();
    }

    public void GoalExercise()
    {
        SetBroadGoal();
        Console.Write("How many weeks do you hope to accomplish this by? ");
        timeFrame = int.Parse(Console.ReadLine());
        Console.WriteLine("\nWhat are some daily goals you can set to work towards your bigger goal?");

        DateTime startTime = DateTime.Now;
        while(DateTime.Now < startTime.AddSeconds(GetDuration()))
        {
            _dailyGoals.Add(Console.ReadLine());
        }

        string input = "";
        while (input != "y")
        {
            Console.Write($"Great! Are you willing to commit to these goals for the next {timeFrame} week(s) [y/n]? ");
            input = Console.ReadLine();

            if (input != "y" && DateTime.Now >= startTime.AddSeconds(GetDuration()))
            {
                Console.WriteLine("\nWrong! You're Time is already up but we're gonna keep doing this until you get it right.");
            }else if (input != "y")
            {
                Console.WriteLine("\nWrong! Try again.");
            }
        }

        Console.Clear();
        Console.WriteLine("\nGreat! Remeber to write your goals down somewhere.");
        foreach (string goal in _dailyGoals)
        {
            Console.WriteLine(goal);
        }

        animation.WaitingAnimation(2);

    }

}