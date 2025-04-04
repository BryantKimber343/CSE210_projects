using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> exercises = new List<Activity>();
        Running running = new Running("2023-10-01", 30, 5.0);
        Cycling cycling = new Cycling("2023-10-02", 45, 15.0);
        Swimming swimming = new Swimming("2023-10-03", 60, 20);

        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);
        
        Console.Clear();
        foreach (Activity exercise in exercises)
        {
            exercise.DisplaySummary();
            Console.WriteLine();
        }
        
    }
}