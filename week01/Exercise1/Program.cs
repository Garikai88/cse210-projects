using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // Ask for a grade percentage
        Console.Write("Enter your grade percentage:");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";
        string sign = "";

       // Determine letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Deterrmine sign (+ or -)
        int lastDigit = percentage % 10;

        if (letter != "F")
        {
            if (letter == "A" && lastDigit < 3)
            {
                sign = "-";
            }
            else if (letter != "A")
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
        }



        // Print the final grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Pass / fail message
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");

        }
        else
        {
            Console.WriteLine("Keep trying! You'll get it next time.");
        }

        // Step 1: Generate a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;
        // Step 2: Loop until the guess matches the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

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
                Console.WriteLine("You guesssed it!");
            }

            List<int> numbers = new List<int>();
            int number;

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            // Collect numbers until user enters 0
            do
            {
                Console.Write("Enter number:");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    numbers.Add(number);
                }

            } while (number != 0);

            // Core Requirements
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            // Output results
            Console.WriteLine($":The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

        

            DisplayWelcome();

            string userName = PromptUserName();
            int favouriteNumber = PromptUserNumber();
            int squareValue = squareNumber(favouriteNumber);

            DisplayResult(userName, squareValue);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        

        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number:");
            string input = Console.ReadLine();
            return int.Parse(input);
        }
        
        static int squareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name},the square of your favourite number is {squareNumber}");
        }

        }
    }



