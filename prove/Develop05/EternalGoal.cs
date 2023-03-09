using System;

public class EternalGoal : Goal
{
    public EternalGoal()
    { }
    public EternalGoal(Goal goal)
    {
        this._name = goal.GetName();
        this._description = goal.GetDescription();
        this._completed = goal.isCompleted();
        this._points = goal.GetPoints();
    }
    public override void SetCompleted()
    {
        _completed = false;
    }

}