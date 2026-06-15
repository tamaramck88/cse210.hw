using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        int pointsEarned = _goals[goalIndex].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine();
        Console.WriteLine($"You earned {pointsEarned} points!");
        Console.WriteLine($"Your total score is now {_score}.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":

                    _goals.Add(
                        new SimpleGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            bool.Parse(parts[4])
                        )
                    );

                    break;

                case "EternalGoal":

                    _goals.Add(
                        new EternalGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3])
                        )
                    );

                    break;

                case "ChecklistGoal":

                    _goals.Add(
                        new ChecklistGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            int.Parse(parts[6]), // target count
                            int.Parse(parts[4]), // bonus
                            int.Parse(parts[5])  // current count
                        )
                    );

                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}