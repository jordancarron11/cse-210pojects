using System;

public class Resume

{
    public string client_name;

    public List<Job> _jobs = new List<Job>();

    public void displayResume()
    {
        Console.WriteLine($"Name: {client_name}");
        Console.WriteLine("Jobs: ");

        foreach(Job job in _jobs)
        {
            job.DisplayJobs();
        }
    }

}