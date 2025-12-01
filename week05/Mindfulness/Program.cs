using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye! Thanks for practicing mindfulness.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.Please select 1-4");
            }
                    

            Console.WriteLine("\nPress Enter key to return to the menu.....🔃");
            Console.ReadLine();

        }
    }
}