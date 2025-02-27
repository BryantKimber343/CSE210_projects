
class Reflect : Activity
{

    Animation animation = new Animation();
    private List<string> _prompts = ["Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"];

    public Reflect(): base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0){}

    public void ReflectionExercise()
    {
        Random random = new Random();
        int indexPrompt = random.Next(0, _prompts.Count);
        Console.WriteLine("Think about this prompt for the next few seconds.\n");
        Console.WriteLine("----" + _prompts[indexPrompt] + "----");
        Console.Write("Starts in: ");
        animation.CountdownDisplay(8);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(GetDuration()))
        {
            int indexQuestion = random.Next(0, _questions.Count);
            Console.WriteLine(_questions[indexQuestion]);
            animation.CountdownDisplay(8);
            _questions.Remove(_questions[indexQuestion]);
        }
        
    }

    
}