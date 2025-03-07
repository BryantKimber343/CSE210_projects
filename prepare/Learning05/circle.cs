using System.Drawing;

public class Circle : Shape
{
    private double _radius;

    public Circle():base()
    {
        _radius = 0;
    }

    public Circle(string color,double radius):base(color)
    {
        _radius = radius;
    }

    public override double CalcArea()
    {
        return Math.PI * _radius * _radius;
    }

}