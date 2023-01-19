using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.job_title = "IT Manager";
        job1.company_name = "Samsung";
        job1.start_year = 2020;
        job1.end_year = 2022;

        Job job2 = new Job();
        job2.job_title = "Senior Manager";
        job2.company_name = "Google";
        job2.start_year = 2022;
        job2.end_year = 2025;

        Resume current_resume = new Resume();
        current_resume.client_name = "Jordan Carron";

        current_resume._jobs.Add(job1);
        current_resume._jobs.Add(job2);

        current_resume.displayResume();
    }

   
}