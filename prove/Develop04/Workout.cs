using System;
using System.Diagnostics;

public class WorkoutActivity : Activity
{

private List<string> _activites;
    public WorkoutActivity() : base()
    {
        SetActivityName("Workout Activity");
        SetActivityDescription("This activity will help you stay healthy by choosing a 50 second workout and giving you a rest period for them");
        _activites = new List<string> 
        {
            "Wallsits",
            "Burpies",
            "Situps",
            "Push-ups",
            "Plank",
            "High-knees"
        };

    }

    public void RunWorkoutActivity()
    {
        ActivityStartWorkout();
        WorkoutTime();
        Console.WriteLine("Congratulations you worked out for 1 minute");
        DisplaySpinner(3);
        Console.Clear();
    }

    public void WorkoutTime()
    {

        for(int i = 0; i < 1; i++)
        {
            WorkoutCount();
        }
    }

    private void CooldownCount()
    {
        
    }
    private void WorkoutCount()
    {
        int randomIndex = new Random().Next(0, _activites.Count());
        string randomActivity = _activites[randomIndex];
        for (int i = 50; i>-1; i--)
        {     
            Console.Write($"{randomActivity}\n\nStart!\nYou have {i} Seconds left");
            Thread.Sleep(1000);
            Console.Clear();
        }
        for (int i = 10; i > -1; i--)
        {
            
            Console.Write($"{randomActivity}\n\nRest!\nYou have {i} Seconds left");
            Thread.Sleep(1000);
            Console.Clear();
            
        }

    }
    

}