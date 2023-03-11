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
    public ChecklistGoal(string name, string description, int points, bool completed, int completedCounter, int BonusPoints, int bonusCount)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
        _completedCounter = completedCounter;
        _bonusPoints = BonusPoints;
        _bonusCount = bonusCount;
    }


    public override void SetCompleted()
    {
        if (!_completed)
        {
            _completedCounter++;
            _completed = (_completedCounter >= _bonusCount);
            if (_completed)
            {
                _pointsEarned = (_points + _bonusPoints);
            }
            else
            {
                _pointsEarned = _points;
            }
        }
        else
        {
            _pointsEarned = (_points + _bonusPoints);
        }
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
        _bonusPoints = GetANumber(bonusPrompt);
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    private void SetBonusCount()
    {
        string bonusCountPrompt = "How many times must you complete the goal to receive bonus points? ";
        _bonusCount = GetANumber(bonusCountPrompt);

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
}