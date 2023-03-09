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
        /*using (StreamWriter outputFile = new StreamWriter(fileName))
        { 
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }*/

        /*for each item in _goals
        get the type
        then call its stringify which will return a string - 
        then write to file
*/

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
            if (goal.GetType() == typeof(SimpleGoal))
            {
                Console.WriteLine("Simple Goal");
                Console.WriteLine(goal.Stringify());
            }
            else if (goal.GetType() == typeof(EternalGoal))
            {
                Console.WriteLine("Eternal Goal");
                Console.WriteLine(goal.Stringify());
            }
            else if (goal.GetType() == typeof(ChecklistGoal))
            {
                Console.WriteLine("Checklist Goal");
                Console.WriteLine(goal.Stringify());    //this works. calls the correct stringify

            }
            else
            {
                Console.WriteLine("No goal type found");

            }
        });


    }
    public void LoadGoals(string fileName)
    {

    }

    public void RecordEvent()
    {
        //pick a goal to record event for

    }
}