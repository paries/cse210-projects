using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Homework Project.");

        Assignment assignment1 = new Assignment("Homer Simpson", "Addition");
        Console.WriteLine(assignment1.GetSummary());

        // Now create the derived class assignments
        MathAssignment mathAssignment = new MathAssignment("Ned Flanders", "Division", "1.3", "1-14");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Matt Daemon", "Fun With School", "Does Homework work");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}