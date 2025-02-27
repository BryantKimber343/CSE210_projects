
class Breath : Activity
{
    Animation animation = new Animation();
    public Breath() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0){}

    public void BreathingExercise()
    {
        Console.Clear();
        for (int i = 0; i < GetDuration()/10 ; i++)
        {   
            Console.WriteLine("\nBreath in...");
            animation.CountdownDisplay(5);
            Console.WriteLine();
            Console.WriteLine("Breath out...");
            animation.CountdownDisplay(5);
        }
    }
}