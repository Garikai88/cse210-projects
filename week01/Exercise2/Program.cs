using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    
        // Ask for a grade percentage
        Console.Write("Enter your grade precentage:");
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

    }
}
