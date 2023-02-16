using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assign1 = new Assignment("Jodie", "Pickles Chapter 2");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment math1 = new MathAssignment("Chapter 1", "Even problems 2-20", "Jodie", "Prime Numbers");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Brandon", "Kentucky", "Crops of Kentucky");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}