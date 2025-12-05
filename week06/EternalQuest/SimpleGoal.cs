namespace GoalsApp
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        // Constructor: initializes with name, description, points
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false; // this is a default state
        }

        // RecordEvent: mark complete and award points once
        public override void RecordEvent(GoalManager manager)
        {
            if (!_isComplete)
            {
                _isComplete = true;
                manager.AddScore(Points);
                manager.Notify($"Complete '{ShortName}' (+{Points})");
            }

            else
            {
                manager.Notify($"'{ShortName}' is already complete.");
            }
        }

        // IsComplete: returns whether this goal is finished
        public override bool IsComplete() => _isComplete;

        // GetDetailsString: human-friendly display with checkbox
        public override string GetDetailsString()
        {
            string checkbox = _isComplete ? "[X]" : "[ ]";
            return $"{checkbox} {ShortName} - {Description} ({Points} pts)";
        }

        // GetStringRepresentation: machine-friendly format for saving/loading
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{ShortName}|{Description}|{Points}|{_isComplete}";
        }               
    }
}