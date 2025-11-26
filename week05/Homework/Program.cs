using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignmemnt writingAssignmemnt = new WritingAssignmemnt("Mary Waters", "European History", "The Causes of World War 2");
        Console.WriteLine(writingAssignmemnt.GetSummary());
        Console.WriteLine(writingAssignmemnt.GetWritingInformation());
    }
    
}