using System;
using System.Collections.Generic;
using System.IO;

namespace GoalsApp
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        // Add points to the score
        public void AddScore(int points)
        {
            _score += points;
        }

        // Notify user(console output for now)
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }

        // Display player information
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        // List only goal names
        public void ListGoalNames()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i +1}. {_goals[i].ShortName}");
            }
        }

        // List full goal details
        public void ListGoalDetails()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i +1}.{_goals[i].GetDetailsString}");
            }
        }

        // Create s new goal (basic console-driven version of it)
        public void CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
        {
            Goal newGoal;

            switch (type.ToLower())
            {
                case "simple":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case "eternal":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "checklist":
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                default:
                    throw new ArgumentException("Unknown goal type");

            }

            _goals.Add(newGoal);
            Notify($"Goal '{name}' created");
        }

        // Record an event for a specific goal
        public void RecordEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                _goals[goalIndex].RecordEvent(this);
            }

            else
            {
                Notify("Invalid goal index.");
            }
        }

        // Save goals to file
        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score); // Save score first
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Notify("Goals saved successfully.");
        }

        // Load goals from file
        public void LoadGoals(string filename)
        {
            if (!File.Exists(filename))
            {
                Notify("Save file not found.");
                return;
            }

            _goals.Clear();

            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]); //First line is score

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        {
                           // restore completion state
                           //hack: use reflection or cunstructor overload if needed 
                        };
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        var checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));

                        // restore amount completed
                        for (int j = 0; j < int.Parse(parts[4]); j++)
                        {
                            checklist.RecordEvent(this);
                        }

                        _goals.Add(checklist);
                        break;
                                                        
                }
            }

            Notify("Goals loaded successfully.");
        }
    }
}
