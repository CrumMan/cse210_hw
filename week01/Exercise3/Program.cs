using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int secretNumber = r.Next(1, 21);
        int count = 1;
        bool right = false;
        System.Console.WriteLine("Guess the magic number!");
        while (!right)
        {
            string stringGuess = Console.ReadLine();
            if (int.TryParse(stringGuess, out int guess))
            {
                if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == secretNumber)
                {
                    Console.WriteLine($"You guessed it! it took {count} guesses!");
                    System.Console.WriteLine("Do you want to keep playing? yes / no");
                    string play = Console.ReadLine();
                    string lowerPlay = play.ToLower();
                    if (lowerPlay == "y" || lowerPlay == "yes")
                    {
                        secretNumber = r.Next(1, 20);
                    }
                    else { right = true; }
                }
                count++;
                if (!right)
                {
                    System.Console.WriteLine("What is your Guess? ");
                }
            }
            else
            {
                System.Console.WriteLine("NUMBERS ONLY.");
            }
        }
    }
}