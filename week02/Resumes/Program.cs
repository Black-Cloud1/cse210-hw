using System;

class Program
{
    // This will be consider my main function\|/
    static void Main(string[] args)

    {
        //New instance
        Job job1 = new Job();

        job1._jobTitle = "Carpenter";
        job1._companyName = "Norwood Construction";
        job1._startYear = "2018";
        job1._endYear = "2025";
        // New instance
        Job job2 = new Job();

        job2._jobTitle = "Software Engineer";
        job2._companyName = "Nvidia";
        job2._startYear = "2026";
        job2._endYear = "2030";
        // New instance
        Resume myResume = new Resume();

        myResume._name = "Heriberto";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();

    }
}