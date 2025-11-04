using System;
using System.Security.Cryptography.X509Certificates;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create first Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Display the company of the first job
        Console.WriteLine(job1._company);

        //Create a second job
        Job job2 = new Job();
        job2._jobTitle = "UX Designer";
        job2._company = "Apple";
        job2._startYear =2022;
        job2._endYear = 2025;

        // Display the company of the second job
        Console.WriteLine(job2._company);

        // Call the display method for each job
        job1.Display();
        job2.Display();

        // Create resume and add jobs
        Resume myResume = new Resume();
        myResume._name = "Garikai Munamato Mangobe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Access and display first job title from resume
        Console.WriteLine(myResume._jobs[0]._jobTitle);

        // Display full resume
        myResume.Display();

    }
        
}

class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear}-{_endYear})");
    }
}

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs) 
        {
            job.Display();
        }
    }

}