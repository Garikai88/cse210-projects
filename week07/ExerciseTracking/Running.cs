public class Running : Activity
{
    private double _distanceinKm;

    public Running(string date, int minutes, double distanceinKm) : base(date, minutes)
    {
        _distanceinKm = distanceinKm;
        
    }

    public override double GetDistance() => _distanceinKm;
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min):" + 
        $"Distance {GetDistance():0.0} km," +
        $"Speed {GetSpeed():0.0} kph," +
        $"Pace: {GetPace():0.0} min per km";
    }
}