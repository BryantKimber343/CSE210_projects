
class Listing : Activity
{
    Animation animation = new Animation();
    private List<string> _prompts = ["Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"];
    private int _input = 0;

    public Listing() : base("Listing" ,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0){}

    public void ListingExercise()
    {
        Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        Console.WriteLine("---- " + _prompts[index] + " ----");
        Console.Write("Start in ");
        animation.CountdownDisplay(3);
        Console.WriteLine("Please feel free to record any thoughts below: ");
        DateTime startTime = DateTime.Now;
        
        while (DateTime.Now <= startTime.AddSeconds(GetDuration()))
        {
            Console.ReadLine();
            _input++;
        }

        Console.WriteLine($"Nice you entered {_input} entries.");
        animation.WaitingAnimation(2);
        
    }
}