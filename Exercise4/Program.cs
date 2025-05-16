// Program.cs
// Author: Zhili Zhong
// Date: 2025-05-16
// Project: CSE 210 - Exercise 4: List and Generics

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize an empty list to store user input
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Collect user input until 0 is entered (0 is not added to the list)
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out userNumber) && userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Core Requirements:
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge 1: Find the smallest positive number
        int smallestPositive = numbers
            .Where(n => n > 0)
            .DefaultIfEmpty() // avoid exception if no positive numbers
            .Min();

        if (smallestPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch Challenge 2: Sort and display the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
