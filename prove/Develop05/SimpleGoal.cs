using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    { }
    public SimpleGoal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }
}