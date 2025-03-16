using System;
class Program
{

    private static bool done = false;
    private static List<Goal> goals = new List<Goal>();
    private static int userPoints = 0;
    static void Main(string[] args)
    {
        while (!done)
        {
            Console.Clear();
            DisplayGoals();
            DisplayMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    CompleteGoal();
                    break;
                case "3":
                    LoadGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    EditGoal();
                    break;
                case "6":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Current points: " + userPoints);
        Console.WriteLine();
        Console.WriteLine("1. Add a goal");
        Console.WriteLine("2. Complete a goal");
        Console.WriteLine("3. Load goals");
        Console.WriteLine("4. Save goals");
        Console.WriteLine("5. Edit Goal");
        Console.WriteLine("6. Exit");
        Console.Write("Please Choose an option above: ");
    }
    public static void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        int i = 1;
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display");
            
            return;
        }
        else{
            foreach (Goal goal in goals)
        {
            Console.Write($"{i++}. ");
            goal.DisplayGoal();
        }
        }
        Console.WriteLine("\n--------------------");
        
    }

    public static void EditGoal()
    {
        Console.Write("With goal would you like to edit? ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("What would you like to change the description to? ");
        string description = Console.ReadLine();
        Console.WriteLine("What would you like to change the point value to? ");
        int pointValue = int.Parse(Console.ReadLine());
        goals[index - 1].EditGoal(description, pointValue);
    }
    public static void AddGoal()
        {
            Console.WriteLine("What type of goal would you like to add?");
            Console.WriteLine("1. Eternal Goal");
            Console.WriteLine("2. Simple Goal");
            Console.WriteLine("3. Checklist Goal");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a description for your goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter a point value for your goal: ");
            int pointValue = int.Parse(Console.ReadLine());
            
            if (input == 3)
            {
                Console.Write("How many times would you like to complete this goal? ");
                int repetitions = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points would you like to this goal to be worth? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.Write("How many weeks do you have to complete this goal? ");
                int timeFrame = int.Parse(Console.ReadLine()); 
                goals.Add(new ChecklistGoal(pointValue, description, repetitions, bonus, 0, false, timeFrame));
            }
            else if (input == 2)
            {
                Console.Write("How many weeks do you have to complete this goal? ");
                int timeFrame = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(pointValue, description, false, timeFrame));
            }
            else
            {
                goals.Add(new EternalGoal(pointValue, description));
            }
            
            
        }
    public static void CompleteGoal()
    {
        Console.Write("Wich goal would you like to complete? ");
        int index = int.Parse(Console.ReadLine());
        userPoints = userPoints + goals[index - 1].CompleteGoal();
    }

    public static void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        userPoints = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('~');
            if (parts.Length == 2)
            {
                goals.Add(new EternalGoal(int.Parse(parts[1]), parts[0]));
            }
            else if (parts.Length == 7)
            {
                goals.Add(new ChecklistGoal(int.Parse(parts[1]), parts[0], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[3]), parts[5] == "True", int.Parse(parts[6])));
            }
            else
            {
                goals.Add(new SimpleGoal(int.Parse(parts[1]), parts[0], parts[2] == "True", int.Parse(parts[3])));
            }
        }       
    }

    public static void SaveGoals()
    { 
        using StreamWriter outputFile = new StreamWriter("goals.txt", false);
        outputFile.WriteLine(userPoints);
        foreach (Goal goal in goals)
        {
            goal.SaveGoal(outputFile);
        }
        Console.WriteLine("Goals saved!");
        Thread.Sleep(2000);
        
    }
}