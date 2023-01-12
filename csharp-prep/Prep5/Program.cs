using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int number = SquareNumber(favNum);
        DisplayResult(name, number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int a)
    {
        return (a * a);
    }

    static void DisplayResult(string name, int x)
    {

        Console.WriteLine($"{name}, the square of your number is {x}");
    }

}