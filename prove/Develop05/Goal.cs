using System;
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;
    private const string _defaultPointPrompt = "How many points for accomplishing this goal: ";

    public Goal()
    {
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName()
    {
        Console.WriteLine("Enter the goal name: ");
        _name = Console.ReadLine();
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription()
    {
        Console.WriteLine("Enter a short description: ");
        _description = Console.ReadLine();
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetANumber(string prompt)
    {
        Console.WriteLine(prompt);
        bool isValid = false;
        int points;
        do
        {
            string results = Console.ReadLine();
            if (Int32.TryParse(results, out points))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Please enter an integer value.");
            }
        } while (isValid == false);

        return points;

    }
    public virtual bool isCompleted()
    {
        return _completed;
    }
    public virtual void SetCompleted()
    {
        _completed = this.isCompleted();
    }
    public virtual void DisplayGoal()
    {
        string completedDisplay = "[]";
        if (isCompleted())
        {
            completedDisplay = "[X]";
        }
        Console.WriteLine($"{completedDisplay} {_name} - ({_description})");
    }
    public virtual void SetupNewGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public void SetPoints()
    {
        _points = GetANumber(_defaultPointPrompt);
    }
    public virtual string Stringify()
    {
        string item;
        item = "Name:" + this._name + ";" +
        "Description:" + this._description + ";Points:" + this._points +
        ";Completed:" + this._completed + ";";

        return item;

    }


}