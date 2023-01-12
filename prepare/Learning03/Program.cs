using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomNum = new Random();
        int machineNumber = randomNum.Next(1, 101);

        int userGuess = -1;

        while (userGuess != machineNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (machineNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (machineNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }

        }                    
    }
}