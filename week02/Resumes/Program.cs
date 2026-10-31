using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "5KandR LLC";
        job1._jobTitle = "Software Consultant";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "UnitNet Inc";
        job2._jobTitle = "CEO";
        job2._startYear = 2014;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Steve Thundersnow";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}