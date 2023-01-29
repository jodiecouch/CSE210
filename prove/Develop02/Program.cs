using System;
using System.IO;

namespace JournalEntry
{
    static class Globals
    {
        public static Journal book = new Journal();
        public static int promptNum = 0;
        public static Prompts prompt = new Prompts();
        public static string fileName = @"c:\Temp\journal.csv";
    }

    class Program
    {


        static void Main(string[] args)
        {
            int menu;
            Globals.promptNum = 0;

            do
            {
                menu = DisplayMenu();
                if (menu == 1)
                {
                    PromptUser();
                    Globals.promptNum++;
                    if (Globals.promptNum >= Globals.prompt.Max())
                    {
                        Globals.promptNum = 0;
                    }
                }
                else if (menu == 2)
                {
                    DisplayJournal();
                }
                else if (menu == 3)
                {
                    ReadJournal();
                }
                else if (menu == 4)
                {
                    WriteJournal();
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

        static void PromptUser()
        {
            //display a prompt

            Console.WriteLine(Globals.prompt.Display(Globals.promptNum));

            //capture response
            string response = Console.ReadLine();

            //save date, prompt and response to a new Entry class
            Entry e1 = new Entry();
            e1._date = DateTime.Now.ToShortDateString();
            e1._prompt = Globals.prompt.Display(Globals.promptNum);
            e1._response = response;

            Globals.book.Add(e1);
        }
        static void DisplayJournal()
        {
            Globals.book.Display();
        }

        static void ReadJournal()
        {
            Globals.book.Clear();
            Globals.promptNum = 0;

            string[] fileIn = File.ReadAllLines(Globals.fileName);
            foreach (string line in fileIn)
            {
                string[] parts = line.Split(",");

                Entry e1 = new Entry();
                e1._date = parts[0];
                e1._prompt = parts[1];
                e1._response = parts[2];

                Globals.book.Add(e1);
                Globals.promptNum++;
                if (Globals.promptNum >= Globals.prompt.Max())
                {
                    Globals.promptNum = 0;
                }
            }
        }

        static void WriteJournal()
        {
            Globals.book.SaveJournal(Globals.fileName);

        }

    }
}