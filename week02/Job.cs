public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job(string JobTitle, string Company, int startYear, int endYear)
    {
        _jobTitle = JobTitle;
        _company = Company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Behavior: Display the job information
    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} at {_company} in the year of {_startYear} to {_endYear}");
    }

}