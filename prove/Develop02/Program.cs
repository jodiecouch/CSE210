using System;

class Program
{

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        int menu;
        Journal book = new Journal();
        do
        {
            menu = DisplayMenu();
            if (menu == 1)
            {
                PromptUser(book);
            }
            else if (menu == 2)
            {
                DisplayJournal(book);
            }
            else if (menu == 3)
            {
                ReadJournal(book);
            }
            else if (menu == 4)
            {
                WriteJournal(book);
            }

        } while (menu != 5);
    }

    static int DisplayMenu()
    {
        string input;
        int menuItem;
        bool isValid = false;

        Console.WriteLine("Please select one of the following:");
        Console.WriteLine("(1) Write in journal.");
        Console.WriteLine("(2) Display journal.");
        Console.WriteLine("(3) Load a saved journal.");
        Console.WriteLine("(4) Save journal to a file.");
        Console.WriteLine("(5) Exit program.");
        Console.WriteLine("What would you like to do?");

        do
        {
            input = Console.ReadLine();
            if (Int32.TryParse(input, out menuItem))
            {
                if ((menuItem >= 1) && (menuItem <= 5))
                {
                    isValid = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry. Try again.");
            }

        } while (isValid == false);

        return menuItem;
    }

    static void PromptUser(Journal book)
    {
        //display a prompt
        Console.WriteLine("What horse did you pet today?");

        //capture response
        string response = Console.ReadLine();

        //save date, prompt and response to a new Entry class
        Entry e1 = new Entry();
        e1._date = DateTime.Now.ToShortDateString();
        e1._prompt = "What horse did you pet today?";
        e1._response = response;

        book.Add(e1);
    }
    static void DisplayJournal(Journal book)
    {
        book.Display();
    }

    static void ReadJournal(Journal book)
    {

    }

    static void WriteJournal(Journal book)
    {

    }

}