using System;
public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;
    private const string = "How many points for accomplishing this goal: "

    public Goal()
    {
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }
    private void SetName()
    {
        Console.WriteLine("Enter the goal name: ");
        _name = Console.ReadLine();
    }
    public string GetDescription()
    {
        return _description;
    }
    private void SetDescription()
    {
        Console.WriteLine("Enter a short description: ");
        _description = Console.ReadLine();
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetNumber(string prompt, int points)
    {
        Console.WriteLine(prompt);
        bool isValid = false;
        do{
            string results = Console.ReadLine();
            if (Int32.TryParse(results, out points)){
                isValid = true;
            }else{
                Console.WriteLine("Please enter an integer value.");
            }
        }while (isValid == false);

    }
    public bool isCompleted()
    {
        return _completed;
    }
    public virtual void SetCompleted(bool finnished)
    {
        _completed = finnished;
    }
    public virtual string DisplayGoal()
    {
        return ($"{_name} - ({_description})");
    }
    public virtual void SetupNewGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public void SetPoints()
    {
        SetNumber(_defaultPointPrompt, _points)
    }


}