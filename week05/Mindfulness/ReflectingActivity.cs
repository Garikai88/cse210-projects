
using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel during the experience?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?"
    };

    private Random _rand = new Random();

    public ReflectingActivity()
        : base("Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 90)
    {}

    public void Run()
    {
        PromptForDuration();
        DisplayStartingMessage();

        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        ShowSpinner(3);

        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }

    private List<string> ShuffleQuestions()
    {
        return _questions.OrderBy(q => _rand.Next()).ToList();
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        var questions = ShuffleQuestions();

        foreach (var question in questions)
        {
            if (DateTime.Now >= endTime) break;

            Console.WriteLine(question);
            ShowSpinner(4);
        }
    }

}