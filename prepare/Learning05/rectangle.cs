public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle():base()
    {
        _length = 0;
        _width = 0;
    }

    public Rectangle(string color, double length, double width):base(color)
    {
        _length = length;
        _width = width;
    }

    public override double CalcArea()
    {
        return _length * _width;
    }
}