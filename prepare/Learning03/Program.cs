using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 Bob!");
        Display("Item 1");
        Fraction f1 = new Fraction();
        Display(f1.GetFractionString());
        Display(Convert.ToString(f1.GetDecimalValue()));

        Display("Item 2");
        f1.SetNumerator(2);
        Display(Convert.ToString(f1.GetNumerator()));

        f1.SetDenominator(4);
        Display(Convert.ToString(f1.GetDenominator()));

        Display(f1.GetFractionString());
        Display(Convert.ToString(f1.GetDecimalValue()));

        Display("Item 3");
        Fraction f2 = new Fraction(3);
        Display(f2.GetFractionString());
        Display(Convert.ToString(f2.GetDecimalValue()));

        Display("Item 4");
        Fraction f3 = new Fraction(5, 8);
        Display(f3.GetFractionString());
        Display(Convert.ToString(f3.GetDecimalValue()));


    }
    static void Display(string msg)
    {
        Console.WriteLine(msg);
    }
}