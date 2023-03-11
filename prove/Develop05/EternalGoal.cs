using System;

public class EternalGoal : Goal
{
    public EternalGoal()
    { }
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }
    public override void SetCompleted()
    {
        _completed = false;
    }

}