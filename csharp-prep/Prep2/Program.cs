using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter = "";

        Console.WriteLine("Enter your grade as a percentage:");
        grade = int.Parse(Console.ReadLine());

        //Console.WriteLine("Hello Prep2 World!");
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations on passing.");
        }
        else
        {
            Console.WriteLine("Better luck next time, Loser.");
        }
    }
}