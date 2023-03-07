using System;
public class GameOfGoals
{
    List<Goal> _goals = new List<Goal>();
    int _points;

    public int PointsTotal()
    {
        return _points;
    }
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
            Console.WriteLine(goal.DisplayGoal());
        });
    }
}