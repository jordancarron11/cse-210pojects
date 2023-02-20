using System;
using System.Diagnostics;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _userSessionLengthInput = 0;


    public Activity()
    {
        _spinnerCounter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }
    public void DisplayStartingtMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}!\n");
    }

    public void DisplayDescription()
    {
        Console.WriteLine($"{_activityDescription}\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations you did it!\nYou have complete {_userSessionLengthInput} seconds of the {_activityName}.");
        DisplaySpinner(3);
        Console.Clear();
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }

    public void ActivityStart()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        Console.Clear();
    }
    public void ActivityStartWorkout()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetReady();
        Console.Clear();
    }

    public void ActivityEnd()
    {
        DisplayEndingMessage();
    }

}