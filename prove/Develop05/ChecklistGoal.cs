using System;

public class ChecklistGoal : Goal
{
    int _completedCounter;
    int _bonusPoints;
    int _bonusCount;

    public ChecklistGoal()
    {
        _completedCounter = 0;
    }

    public override void SetCompleted()
    {
        _completed = (_completedCounter >= _bonusCount);
    }
    public override string DisplayGoal()
    {
        return ($"{_name} - ({_description}) You have completed {_completedCounter}/{_bonusCount}");
    }
    public override void SetupNewGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        
        //what makes bous goal different than other goals
        SetBonusCount();
        SetBonusPoints();
    }

    private void SetBonusPoints()
    {
        string bonusPrompt = "Enter the bonus points. ";
        SetNumber(bonusPrompt, _bonusPoints);
    }
    private void SetBonusCount()
    {
        string bonusCountPrompt = "How many times must you complete the goal to receive bonus points? ";
        SetNumber(bonusCountPrompt, _bonusCount);

    }
}