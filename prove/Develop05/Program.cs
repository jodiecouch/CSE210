using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        GameOfGoals game = new GameOfGoals();
        do
        {
            Console.WriteLine($"You have {game.GetPoints()} points");
            menu.DisplayMain();
            Console.Clear();
            if (menu.Input() == "1")
            {
                Console.WriteLine("Create New Goal");
                string goalType = GetGoalType();
                if (goalType == "1")
                {
                    Console.WriteLine("You picked a simple goal");
                    SimpleGoal goal = new SimpleGoal();
                    goal.SetupNewGoal();
                    //goal.DisplayGoal();
                    game.AddGoal(goal);


                }
                else if (goalType == "2")
                {
                    Console.WriteLine("You picked eternal goal");
                    EternalGoal goal = new EternalGoal();
                    goal.SetupNewGoal();
                    //goal.DisplayGoal();
                    game.AddGoal(goal);

                }
                else if (goalType == "3")
                {
                    Console.WriteLine("You picked a checklist goal");
                    ChecklistGoal goal = new ChecklistGoal();
                    goal.SetupNewGoal();
                    //goal.DisplayGoal();
                    game.AddGoal(goal);
                }
            }
            else if (menu.Input() == "2")
            {
                Console.WriteLine("List Goals");
                game.ListAllGoals();
            }
            else if (menu.Input() == "3")
            {
                Console.WriteLine("Save Goals");
                game.SaveGoals("bob.txt");
            }
            else if (menu.Input() == "4")
            {
                Console.WriteLine("Load Goals");
                game.LoadGoals("bob.txt");

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