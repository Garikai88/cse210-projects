using System;
using System.Runtime.ConstrainedExecution;
using GoalsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Goal Tracker Menu ===");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Name");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;
                case "2":
                    manager.ListGoalNames();
                    break;
                case "3":
                    manager.ListGoalDetails();
                    break;
                case "4":
                    CreateGoalMenu(manager);
                    break;
                case "5":
                    Console.Write("Enter goal number to record event:  ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        manager.RecordEvent(goalIndex -1); 
                    }

                    else
                    {
                        Console.WriteLine("This is an invalid input.");
                    }

                    break;
                case "6":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "7":
                    Console.Write("Enter filename to load goals: ");
                    string loadfile = Console.ReadLine();
                    manager.LoadGoals(loadfile);
                    break;
                case "8":
                    running = false;
                    Console.WriteLine("Exiting Goal Tracker. It was splendid. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
    
            }

        } 
    }

    // Helper method for craeting goals interactively
    static void CreateGoalMenu(GoalManager manager)
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points:  ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                manager.CreateGoal("simple", name, description, points);
                break;

            case "2":
                manager.CreateGoal("eternal", name, description, points);
                break;

            case "3":
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.CreateGoal("checklist", name, description, points, target, bonus);
                break;

            default:
                Console.WriteLine(" This is an invalid goal type");
                break;
        }
    }
}