using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._title = "Debutante";
        job1._company = "Southern Belle";
        job1._startYear = "1999";
        job1._endYear = "2003";

        Job job2 = new Job();
        job2._title = "Eccentric Old Lady";
        job2._company = "The Dream";
        job2._startYear = "2012";
        job2._endYear = "2017";

        Resume res = new Resume();
        res._name = "Essie Ringinhold";
        res._jobs.Add(job1);
        res._jobs.Add(job2);
        res.Display();
        //Console.WriteLine($"Show I can get to job: {res._jobs[0]._title}");

    }
}