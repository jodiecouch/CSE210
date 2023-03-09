using System;

public class ChecklistGoal : Goal
{
    private int _completedCounter;
    private int _bonusPoints;
    private int _bonusCount;

    public ChecklistGoal()
    {
        _completedCounter = 0;
    }

    public override string Stringify()
    {
        string item;
        item = "Name:" + this._name + ";" +
        "Description:" + this._description + ";Points:" + this._points +
        ";Completed:" + this._completed + ";CompletedCounter:" + _completedCounter +
        ";BonusPoints:" + _bonusPoints + ";BonusCount:" + _bonusCount + ";";
        return item;
    }


    public override void SetCompleted()
    {
        _completed = (_completedCounter >= _bonusCount);
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_name} - ({_description}) You have completed {_completedCounter}/{_bonusCount}");
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
        _bonusPoints = GetANumber(bonusPrompt);
    }
    private void SetBonusCount()
    {
        string bonusCountPrompt = "How many times must you complete the goal to receive bonus points? ";
        _bonusCount = GetANumber(bonusCountPrompt);

    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}