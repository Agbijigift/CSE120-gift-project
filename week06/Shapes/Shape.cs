using System;
using System.Collections.Generic;
using System.IO;
public abstract class Shape
{
    protected string _color;
    protected string _nameOfShape;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
     public string GetNameOfShape()
    {
        return _nameOfShape;
    }
    public void SetNameOfShape(string nameOfShape)
    {
        _nameOfShape = nameOfShape;
    }
    public abstract double GetArea();

}