using System;
using System.Globalization;

// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int NumberSquared = SquareNumber(number);
        DisplayResult(NumberSquared, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome weary traveler! Here be the foundations of our progam.");
    }

    static string PromptUserName()
    {
        Console.Write("What be ye called? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What be yer favorite number? ");
        int FavoriteNumber = Convert.ToInt16(Console.ReadLine());
        return FavoriteNumber;
    }

    static int SquareNumber(int num)
    {
        int numSquared = num*num;
        return numSquared;
    }

    static void DisplayResult(int num, string name)
    {
        Console.WriteLine($"Nice to meet yer acquaintance {name}, yer favorite number squared is {num}");
    }
}