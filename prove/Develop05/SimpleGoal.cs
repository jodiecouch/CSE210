using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    { }
    public SimpleGoal(Goal goal)
    {
        this._name = goal.GetName();
        this._description = goal.GetDescription();
        this._completed = goal.isCompleted();
        this._points = goal.GetPoints();
    }

    /* public string Stringify()
     {
         string item;
         item = "Type:SimpleGoal;Name:" + this._name + ";" +
         "Description:" + this._description + ";Points:" + this._points +
         "Completed:" + this._completed;

         return item;

     }*/
}