using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "John Deer";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._member = "Liz";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}