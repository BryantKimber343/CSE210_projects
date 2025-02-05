class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }
    public Fraction (int num, int den)
    {
        _top = num;
        _bottom = den;
    }

    public int getTop()
    {
        return _top;
    }
    public int getBottom()
    {
        return _bottom;
    }
    public void setTop(int top)
    {
        _top = top;
    }
    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string FractionToString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}