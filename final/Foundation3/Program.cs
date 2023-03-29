using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Fundamental Freedoms", "A look at the founding father's definition of fundamental freedoms.", "4/10/2023", "10:10 AM", "1776 Freedom Street Library", "Freedom", "PA", "USA", "George Washington", 35);
        Console.WriteLine(lecture.Short());
        Console.WriteLine(lecture.Standard());
        Console.WriteLine(lecture.FullDetails());

        Reception reception = new Reception("Parker/Wilson", "Parker/Wilson wedding reception", "4/1/2023", "10:10 AM", "123 Happy Street", "Happyville", "ID", "USA", "parker-wilson@myevents.com");
        Console.WriteLine(reception.Short());
        Console.WriteLine(reception.Standard());
        Console.WriteLine(reception.FullDetails());

        Outdoor outdoor = new Outdoor("Bow Hunting Safety", "Bow hunting safety field class.", "4/19/2023", "10:10 AM", "1545 E 200 N", "Huntsville", "ND", "USA", "48 degrees and windy");
        Console.WriteLine(outdoor.Short());
        Console.WriteLine(outdoor.Standard());
        Console.WriteLine(outdoor.FullDetails());

    }
}