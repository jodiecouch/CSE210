using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int userNumber;
        List<int> numList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter number:");
            input = Console.ReadLine();
            if (Int32.TryParse(input, out userNumber))
            {
                if (userNumber != 0)
                {
                    numList.Add(userNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry. Try again.");
            }

        } while (userNumber != 0);

        float sum = 0;
        float counter = 0;
        float avg = 0;
        int max = 0;

        foreach (int num in numList)
        {
            sum += num;
            counter++;
            if (num > max)
            {
                max = num;
            }
        };
        avg = sum / counter;
        Console.WriteLine($"Sum is {sum}. Average is {avg}. Maximum is {max}. Counter is {counter}.");

    }
}