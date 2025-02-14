 using System;
public class Square:Shape
{
    private double _sides;
    public double GetSides()
    {
        return _sides;
    }
    public void SetSides(double sides)
    {
        _sides = sides;
    }
    public override double GetArea()
    {
        return Math.Round(Math.Pow(_sides, 2));
    }
}

