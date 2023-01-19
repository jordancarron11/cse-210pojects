using System;

public class Job
{
    
        public string job_title;
        public string company_name;
        public int start_year;
        public int end_year;
    public void DisplayJobs()
    {
        Console.WriteLine($"{job_title} ({company_name}) {start_year} {end_year}");
    }
}