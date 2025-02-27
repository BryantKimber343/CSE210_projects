class Animation
{
    public void WaitingAnimation(int rep)
    {
        List<string> animationSymbols = new List<string> { "\\", "|", "/", "-" };

        for (int i = rep; i > 0; i--)
        {    
            foreach (string symbol in animationSymbols)
            {
                Console.Write(symbol);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void GetReadyAnimation()
    {
        Console.Clear();
        Console.WriteLine("Get ready... ");
        WaitingAnimation(2);
    }

    public void CountdownDisplay(int start)
    {
        for (int i = start; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    } 

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1: Breathing Exercise");
        Console.WriteLine("2: Listing Exercise");
        Console.WriteLine("3: Reflection Exercise");
        Console.WriteLine("4: Goal Setting Exercise");
        Console.WriteLine("5: Quit");
        Console.Write("Please choose an option: ");
    }
}