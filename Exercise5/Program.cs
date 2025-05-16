// Program.cs
// Author: Zhili Zhong
// Date: 2025-05-16
// Project: CSE 210 - Exercise 5: Functions

using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
    }

    // Function 1: Display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Ask for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number;

        while (!int.TryParse(input, out number))
        {
            Console.Write("Invalid number. Please enter an integer: ");
            input = Console.ReadLine();
        }

        return number;
    }

    // Function 4: Square the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Display the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
