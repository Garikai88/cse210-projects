public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance(); // the distance in km
    public double GetSpeed() => (GetDistance() / _minutes) * 60;
    public double GetPace() => _minutes / GetDistance();

    public abstract string GetSummary();
}