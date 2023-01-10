using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 100);
        int userNumber = 0;
        string input = "";
        bool play = true;
        int counter = 0;
        string prompt = "Guess a number between 1-100";

        do
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine();
            counter++;

            if (Int32.TryParse(input, out userNumber))
            {
                if (userNumber == magicNumber)
                {

                    Console.WriteLine($"Winner! Winner! Number of guesses {counter}");
                    Console.WriteLine("Would you like to play again?('yes' or 'no')");
                    string again = Console.ReadLine();
                    if (again == "yes")
                    {
                        magicNumber = generator.Next(1, 100);
                        play = true;
                        counter = 0;
                    }
                    else
                    {
                        play = false;
                    }
                }
                else if (userNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Something is wrong");
                }
            }
            else
            {
                if (input == "exit")
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Try again or type 'exit' to end the game.");
                }
            }
        } while (play == true);


        //Console.WriteLine("Hello Prep3 World!");
    }
}