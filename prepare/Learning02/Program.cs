using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Crew Member";
        job2._company = "Bogey's Burgers";
        job2._startYear = 2026;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Joe Hansen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDestails();

    }
}