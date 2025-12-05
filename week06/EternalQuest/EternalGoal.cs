namespace GoalsApp
{
    public class EternalGoal : Goal
    {
        // Constructor: same as the base, no extra fields are needed
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        // RecordEvent: always awards points, never completes
        public override void RecordEvent(GoalManager manager)
        {
            manager.AddScore(Points);
            manager.Notify($"Progress recorded for '{ShortName}' (+{Points})");
        }

        // Eternal goals never complete
        public override bool IsComplete() => false;

        // Human-friendly details string
        public override string GetDetailsString()
        {
            return $"[] {ShortName} - {Description} ({Points} pts each time)";
        }

        // Machine-frienkdly representation for saving or loading
        public override string GetStringRepresentation()
        {
            return $"EternalGoal| {ShortName}| {Description}|{Points}";
        }
        
    }
}