namespace GoalsApp
{
    // Abstarct base class: defines the common structure for all goals
    public abstract class Goal
    {
        // The shared fields
        protected string _shortName;
        protected string _description;
        protected int _points;

        // Constructor: initializes common goal data
        protected Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        // Properties: safe way to expose fields
        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        // Abstarct methods: must be implpemented by subclasses
        public abstract void RecordEvent(GoalManager manager);
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }
}