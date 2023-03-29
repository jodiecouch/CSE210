using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercise = new List<Activity>();

        Run jog = new Run("3/29/2023", 2, .25);
        exercise.Add(jog);

        Cycle bike = new Cycle("3/20/2023", 25, 15);
        exercise.Add(bike);

        Swim swim = new Swim("3/25/2023", 30, 90);
        exercise.Add(swim);


        exercise.ForEach(delegate (Activity act)
        {
            Console.WriteLine(act.GetSummary());
        });
    }
}