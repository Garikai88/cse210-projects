using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

// I have added more code that will allow the user to include an image file path
// Users will visually document their experiences.
// I have also introduced achievement tracking for consistent journaling.
// I have also coded for Streak logic calculations which calculates consecutive days.
// These enhancemenst will promote emotional expression, engangement and habit building. 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write a new entry ");
            Console.WriteLine("2. Display all entries.");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.WriteLine("Optional image path: ");
                    string imagePath = Console.ReadLine();
                    Entry entry = new Entry(prompt, response, imagePath);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.loadFromFile(loadFile);
                    break;

                case "5":
                    journal.DisplayAchievements();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("invalid option. Please try again.");
                    break;


            }

        }
    }
}

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "How are you feeling today?",
        "Describe a challenge you overcame recently",
        "What did you achieve today",
        "How are you going to achieve your goals tomorrow?",
        "What did your experiances for today teach you?",
        "What entries would be important for your journal this week?",

    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; private set; }
    public sbyte EntryText { get; private set; }
    public string ImagePath { get; private set; }

    public Entry(string promptText, string entryText, string imagePath = "")
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        PromptText = promptText;
        EntryText = entryText;
        ImagePath = imagePath;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        if (!string.IsNullOrWhiteSpace(ImagePath))
            Console.WriteLine($"Image: {ImagePath}");
    }

    public string ToFileFormatat(string line)
    {
        return $"{Date} | {PromptText} | {EntryText} | {ImagePath}";
    }

    public static Entry FromFileFormat(String line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2], parts.Length > 3 ? parts[3] : "") { Date = parts[0] };
    }
}

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormatat());
            }

        }
        Console.WriteLine("Journal saved successfuly");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry entry = entry.FromFileFormat(line);
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded successfully.");
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void DisplayAchievements()
    {
        Console.WriteLine("Your achievements:");

        if (_entries.Count == 0)
        {
            Console.WriteLine("- No entries yet.");
            return;
        }

        Console.WriteLine("- First Entry: ");

        int longEntries = _entries.Count(e => e.EntryText.Length > 200);
        if (longEntries > 0)
            Console.WriteLine("- Long Entry (200+ characters): ");

        int streak = CalculateStreak();
        if (streak >= 3)
            Console.WriteLine($"- 3_day Streak: ({streak}) days");

        Console.WriteLine($"- Total Entries: {_entries.Count}");
    }

    private int CalculateStreak()
    {
        var dates = _entries
        .Select(e => DateTime.Parse(e.Date))
        .Distinct()
        .OrderByDescending(d => d)
        .ToList();

        int streak = 0;
        DateTime current = DateTime.Today;

        foreach (var date in dates)
        {
            if (date.Date == current)
            {
                streak++;
                current = current.AddDays(-1);
            }

            else
            {
                break;
            }
        }

        return streak;
    }
            
}

