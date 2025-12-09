public class Cycling : Activity
{
    private double _speedkph;

    public Cycling(string date, int minutes, double speedkph) : base(date, minutes)
    {
        _speedkph = speedkph;
    }

    public override double GetDistance() => (_speedkph * GetMinutes()) / 60;

    public override string GetSummary()
    {
        return $"{GetDistance()} Cycling ({GetMinutes()} min):" + 
        $"Distance {GetDistance():0.0} km," +
        $"Speed {_speedkph:0.0} kph," +
        $"Pace: {GetPace():0.00} min per km";
    }
}