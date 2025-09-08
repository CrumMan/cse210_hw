using System;
namespace week02.Resumes
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume1 = new Resume();
            Job job1 = new Job();
            Job job2 = new Job();

            job1._jobtitle = "Software Engineer";
            job1._company = "Microsoft";
            job1._startDate = 2019;
            job1._endDate = 2022;


            job2._jobtitle = "Manager";
            job2._company = "Apple";
            job2._startDate = 2022;
            job2._endDate = 2023;

            resume1._name = "Allison Rose";

            resume1.jobs.Add(job1);
            resume1.jobs.Add(job2);

            resume1.DisplayResume();



        }
    }
}