using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        // Console.WriteLine($"You entered {number}");
        int guess = 0;
        int tries = 0;
        
        do
        {
            
            Console.Write("What is your guess: ");
            string guessString = Console.ReadLine();
            guess = Convert.ToInt16(guessString);
            if (number > guess)
            {
                Console.WriteLine("Higher");
            } else if (number < guess)
            {
                Console.WriteLine("Lower");
            } else
            {
                Console.WriteLine("Good job, you guessed it!");
                number = guess;
            }
            
        
            tries++;
            
        } while (number != guess);
        Console.WriteLine($"it took you {tries} times to guess it.");
    }
}