using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Event e = new Event("Type", "Title", "Description", "4/1/2023", "10:10 AM", "123 Happy Street");

        e.DisplayFull();
        e.DisplayShort();
        e.DisplayStandard();
    }
}