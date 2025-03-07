using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();
       shapes.Add(new Rectangle("red", 5, 10));
       shapes.Add(new Square("orange", 4.5));
       shapes.Add(new Circle("pink", 12.5));
       foreach (Shape shape in shapes)
       {
            Console.WriteLine("Color: " + shape.GetColor() + "\nArea: " + shape.CalcArea() + "\n");
       }
    }
}