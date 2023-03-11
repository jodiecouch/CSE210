using System;
using System.Web;



public class GameOfGoals
{
    List<Goal> _goals = new List<Goal>();
    int _points;


    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }

    public void RemoveGoal(Goal goalGone)
    {
        _goals.Remove(goalGone);
    }
    public void ListAllGoals()
    {
        _goals.ForEach(delegate (Goal goal)
        {
            goal.DisplayGoal();
        });
    }

    public int GetPoints()
    {
        return _points;
    }
    private void SetPoints()
    {

    }

    public void SaveGoals(string fileName)
    {
        string line;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            /* //This Works
            List<SimpleGoal> simpleList = _goals.OfType<SimpleGoal>().ToList();
            simpleList.ForEach(delegate (SimpleGoal simple)
                    {
                        simple.DisplayGoal();
                    });
            */
            //This also works and will keep goals in order entered:)
            _goals.ForEach(delegate (Goal goal)
            {
                line = "";
                if (goal.GetType() == typeof(SimpleGoal))
                {
                    line = "Type:Simple Goal;";
                    line = line + goal.Stringify();
                }
                else if (goal.GetType() == typeof(EternalGoal))
                {
                    line = "Type:Eternal Goal;";
                    line = line + goal.Stringify();
                }
                else if (goal.GetType() == typeof(ChecklistGoal))
                {
                    line = "Type:Checklist Goal;";
                    line = line + goal.Stringify();         //this works. calls the correct stringify

                }
                else
                {
                    Console.WriteLine("No goal type found");

                }
                Console.WriteLine(line);
                outputFile.WriteLine($"{line}");
            });
        }
    }
    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string goalType = "";
        string name = "";
        string description = "";
        int points = 0;
        bool completed = false;
        int completedCounter = 0;
        int bonusPoints = 0;
        int bonusCount = 0;
        _goals.Clear();

        foreach (string line in lines)
        {

            string[] parts = line.Split(";");
            for (int i = 0; i < parts.Length; i++)
            {
                //each item in my array is now a Field:Value
                //break each item in to field/value pairs

                string[] more = parts[i].Split(":");

                if (more.Length >= 2)
                {
                    string field = more[0];
                    string value = more[1];

                    if (field == "Type")
                    {
                        goalType = value;
                    }
                    if (field == "Name")
                    {
                        name = value;
                    }
                    if (field == "Description")
                    {
                        description = value;
                    }
                    if (field == "Points")
                    {
                        if (!(Int32.TryParse(value, out points)))
                        {
                            points = 0;
                        }
                    }
                    if (field == "Completed")
                    {
                        bool.TryParse(value, out completed);
                    }
                    //checklist fields
                    if (field == "CompletedCounter")
                    {
                        if (!(Int32.TryParse(value, out completedCounter)))
                        {
                            completedCounter = 0;
                        }
                    }
                    if (field == "BonusPoints")
                    {
                        if (!(Int32.TryParse(value, out bonusPoints)))
                        {
                            bonusPoints = 0;
                        }
                    }
                    if (field == "BonusCount")
                    {
                        if (!(Int32.TryParse(value, out bonusCount)))
                        {
                            bonusCount = 0;
                        }
                    }

                };
            }

            //create the class from the line and add it to _goals

            if (goalType == "Simple Goal")
            {
                SimpleGoal simple = new SimpleGoal(name, description, points, completed);
                _goals.Add(simple);
            }
            if (goalType == "Eternal Goal")
            {
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }
            if (goalType == "Checklist Goal")
            {
                ChecklistGoal check = new ChecklistGoal(name, description, points, completed, completedCounter, bonusPoints, bonusCount);
                _goals.Add(check);
            }
        };

    }

    public void RecordEvent()
    {
        //pick a goal to record event for

    }
}