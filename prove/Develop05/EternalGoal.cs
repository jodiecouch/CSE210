using System;

public class EternalGoal : Goal
{
    public override void SetCompleted()
    {
        _completed = false;
    }
}