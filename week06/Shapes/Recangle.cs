using System;
public class Recangle:Shape
{
    private double _length;
    private double _width;
    public double GetLenght()
    {
        return _length;
    }
    public void SetLenght(double lenght)
    {
        _length = lenght;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public override double GetArea()
    {
     return Math.Round (_width * _length);
    }
}