using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");
            Console.WriteLine();

            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Go lower.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Go higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
    }
}