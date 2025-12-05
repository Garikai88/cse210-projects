namespace GoalsApp
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        // Constructor: initializes with name, description, points, target, and bonus
        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        // RecordEvent: increments progress, awards points, and bonus if target reached
        public override void RecordEvent(GoalManager manager)
        {
            _amountCompleted++;

            manager.AddScore(Points);
            manager.Notify($"Progress recorded for '{ShortName}' (+{Points})");
        }
    

    // IsComplete: true only when target is reached
    public override bool IsComplete() => _amountCompleted >= _target;

        // Human-friendly detials string
        public override string GetDetailsString()
        {
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            return $"{checkbox} {ShortName} - {Description} ({Points} pts each, Bonus {_bonus})" +
                    $"Progress: {_amountCompleted}/{_target}";
        }

        // Machine-friendly representation for saving/loading
        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{ShortName}|{Description}|{Points}|{_amountCompleted}|{_target}|{_bonus}";
        } 
    }       
        
}