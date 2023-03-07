using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        GameOfGoals game = new GameOfGoals();
        do
        {
            menu.DisplayMain();
            Console.Clear();
            if (menu.Input() == "1")
            {
                Console.WriteLine("Create New Goal");
                string goalType = GetGoalType();
                if (goalType == "1")
                {
                    Console.WriteLine("You picked a simple goal");
                }
                else if (goalType == "2")
                {
                    Console.WriteLine("You picked eternal goal");
                }
                else if (goalType == "3")
                {
                    Console.WriteLine("You picked a checklist goal");
                }
            }
            else if (menu.Input() == "2")
            {
                Console.WriteLine("List Goals");
                //Reflecting reflect = new Reflecting();
                //reflect.Play();
            }
            else if (menu.Input() == "3")
            {
                Console.WriteLine("Save Goals");
                //Listing listIt = new Listing();
                //listIt.Play();
            }
            else if (menu.Input() == "4")
            {
                Console.WriteLine("Load Goals");

            }
            else if (menu.Input() == "5")
            {
                Console.WriteLine("Record Event");

            }
            else
            {
                Console.WriteLine("Good bye");
            }
        } while (menu.Play() != false);
    }

    static string GetGoalType()
    {
        string input;
        bool isValid = false;
        do
        {
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create?");
            input = Console.ReadLine();
            if (input == "1" | input == "2" | input == "3")
            {
                isValid = true;
            }

        } while (isValid == false);

        return input;
    }
}