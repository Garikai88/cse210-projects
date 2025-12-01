using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _items = new List<string>();
    private static Random _rand = new Random();

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
        0)
    {}
    
    public void Run()
    {
        PromptForDuration();
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Get ready....");
        ShowCountDown(5);

        Console.WriteLine("\nStart listing items: ");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item);
            }
        }

        Console.WriteLine($"\nYou listed {_items.Count} items:");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}
