using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MathAssignment mathHomework = new MathAssignment("John", "Integrals", "Section 7.3", "Problems 3-7");
        EnglishAssignment englishAssignment = new EnglishAssignment("Sally", "Article Synthesis", "CLimate Control and the Future");

        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(englishAssignment.GetSummary());
        Console.WriteLine(englishAssignment.GetWritingInformation());

    }
}