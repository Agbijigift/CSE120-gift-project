using System;
public class MathAssignment:Assignment
{
    protected string _textBookSection;
    protected string _problem;
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string section)
    {
        _textBookSection = section;
        
    }
    public string GetProblem()
    {
        return _problem;
    }
    public void SetProblem(string problem)
    {
        _problem = problem;
        
    }


    public string GetHomeWorkList()
    {
     return $"{_textBookSection} - {_problem}";

    }
}