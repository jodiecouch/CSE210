using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BOB");

        Menu menu = new Menu();
        do
        {
            menu.Display();
            if (menu.Input() == "1")
            {
                Console.WriteLine("Breathing");

            }
            else if (menu.Input() == "2")
            {
                Console.WriteLine("Reflecting");
            }
            else if (menu.Input() == "3")
            {
                Console.WriteLine("Listing");
            }
            else
            {
                Console.WriteLine("Good bye");
            }
        } while (menu.Play() != false);
    }
}