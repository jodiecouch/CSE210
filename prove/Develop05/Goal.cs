using System;
public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool isCompleted()
    {
        return _completed;
    }
    public void SetCompleted(bool finnished)
    {
        _completed = finnished;
    }
    public string DisplayGoal()
    {
        return ($"{_name} - ({_description})");
    }


}