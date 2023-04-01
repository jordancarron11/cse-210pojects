using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(20, 2.5);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(60, 10);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(30, 20);
        activitiesList.Add(swimming);


        //display activity summaries
        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}