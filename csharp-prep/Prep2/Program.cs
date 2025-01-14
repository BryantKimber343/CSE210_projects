using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input the semster grade: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"You got a(n) {letter}");
        
        if (grade < 70)
        {
            Console.WriteLine("You failed, try harder next time.");
        }
        else
        {
            Console.WriteLine("Congrats on your success, you passed!");
        }

    }
}