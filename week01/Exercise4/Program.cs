using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int input = -1;

        Console.WriteLine("Enter a list of numbers, type the number 0 to end.");

        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        // We compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // We compute the average
        double average = (double)sum / numbers.Count;

        // We then find the maximum
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // We find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // We then sort out the list
        numbers.Sort();

        // To display the results
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}