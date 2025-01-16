using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add any postive integers you wish, type 0 when finished.");
        List<int> numbers = new List<int>();
        int input =1;

        // prompt user for numbers and add to list
        while (input != 0)
        {
            Console.Write("Add number: ");
            string inputString = Console.ReadLine();
            input = Convert.ToInt16(inputString);
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // calculate sum
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        //calculate average
        float avg = ((float)sum)/numbers.Count;

        // find maximum value
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {max}");
    }


}