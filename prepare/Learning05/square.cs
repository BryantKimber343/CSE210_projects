public class Square : Shape
{
    private double _side;

    public Square():base()
    {
        _side = 0;
    }
    public Square(string color, double side):base(color)
    {
        _side = side;
    }

    public override double CalcArea()
    {
        return _side * _side;
    }
}