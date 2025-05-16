// Program.cs
// Author: Zhili Zhong
// Date: 2025-05-16
// Project: CSE 210 - Programming Exercise 3: Guess My Number

using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to control whether the player wants to play again
        string playAgain = "yes";

        // Outer loop for playing multiple rounds
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;        // User's current guess
            int guessCount = 0;    // Count the number of guesses

            Console.WriteLine("Guess My Number Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            // Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Validate input to make sure it's a number
                bool isNumber = int.TryParse(input, out guess);
                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                guessCount++;

                // Give feedback to the user
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play another round
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        // End message
        Console.WriteLine("Thanks for playing. Goodbye!");
    }
}
