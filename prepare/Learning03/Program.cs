using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(3);
        Fraction f3 = new Fraction(1, 2);

        Console.WriteLine(f1.FractionToString());
        Console.WriteLine(f2.FractionToString());
        Console.WriteLine(f3.FractionToString());
        Console.WriteLine(f3.getBottom());
        
        f3.setTop(3);
        f3.setBottom(4);

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());

    }
}