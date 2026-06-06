public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        int points = _goals[goalIndex].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
        Console.WriteLine($"Total Score: {_score}");
    }

    public int GetScore()
    {
        return _score;
    }
}