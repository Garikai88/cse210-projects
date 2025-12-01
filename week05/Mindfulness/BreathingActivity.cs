using System;
using System.Threading;


public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", 
            "This activity will help you relax by guiding you to breathe in and out slowly. Clear your mind and focus on your breathing.", 60) {}

        public void Run()
    {
        // Ask the user how long they want to do the activity
        PromptForDuration();
        DisplayStartingMessage();

        int inhaleTime = 4; // seconds to inhale
        int exhaleTime = 6; // seconds to exhale
        int cycleTime = inhaleTime + exhaleTime;

        // Calculate how many full cycles fit into the chosen duration
        int cycles = _duration / cycleTime;

         for (int i = 0; i < cycles; i++)
        {
            BreatheIn(inhaleTime);
            BreatheOut(exhaleTime);
        }

       // Optional: short pasue between cycles
       if (inhaleTime < cycles - 1)
        {
            Console.WriteLine("Take a moment before the next cycle...");
            ShowSpinner(2);
        }

        DisplayEndingMessage();
    }

    private void BreatheIn(int seconds)
    {
        Console.WriteLine("Breathe in...");
        ShowCountDown(seconds);
    }

    private void BreatheOut(int seconds)
    {
        Console.WriteLine("Breathe out...");
        ShowCountDown(seconds);
    }    
}




