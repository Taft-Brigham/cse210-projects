using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Google";
        job1._startYear =  2022;
        job1._endYear  = 2050; 

    //    job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Amazon";
        job2._startYear = 2030;
        job2._endYear = 2040;
        // job2.DisplayJobDetails();

        

        Job job3 = new Job();
        job3._jobTitle = "Hacker";
        job3._company = "Apple";
        job3._startYear = 2040;
        job3._endYear = 2050;
        

        

        // Console.WriteLine($"{resume1._jobList[2]._jobTitle}");
        Resume ezraResume = new Resume();
        ezraResume._name = "Ezra Taft Brigham Essien";
        

        
        ezraResume._jobList.Add(job1);
        ezraResume._jobList.Add(job2);
        ezraResume._jobList.Add(job3);

        ezraResume.DisplayResumeDetails();
        


    }
}