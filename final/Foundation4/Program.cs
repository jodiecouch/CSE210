using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        Run jog = new Run("3/29/2023", 2, .25);
        Console.WriteLine(jog.GetSummary());

        Cycle bike = new Cycle("3/20/2023", 25, 15);
        Console.WriteLine(bike.GetSummary());

        Swim swim = new Swim("3/25/2023", 30, 90);
        Console.WriteLine(swim.GetSummary());
    }
}