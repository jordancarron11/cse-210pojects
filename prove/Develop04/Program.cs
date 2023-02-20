using System;

//I exceded requirments by creating a 4th option to do a 1 minute workout. 
//And also I print out how many times they did each ativity after they quit the program
class Program
{
    static void Main(string[] args)
    {
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;
        int workoutCount = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        string menu = ("Please select one of the following activities: \n\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. One-Minute Workout Activity\n5. Quit\n\n-> ");
        Console.WriteLine();
        bool playing = true;
        while (playing)
        {
            Console.Write(menu);
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Breathing program
                case 1:
                    Console.Clear();
                    BreathingActivity breathingMode = new BreathingActivity();
                    breathingMode.RunBreathingActivity();
                    breatheCount++;
                    break;
                //Reflecting program
                case 2:
                    Console.Clear();
                    ReflectingActivity reflectionMode = new ReflectingActivity();
                    reflectionMode.RunReflectingActivity();
                    reflectCount++;
                    break;
                //Listing program
                case 3:
                    Console.Clear();
                    ListingActivity listingMode = new ListingActivity();
                    listingMode.RunListingActivity();
                    listCount++;
                    break;
                //Workout Activity
                case 4:
                Console.Clear();
                WorkoutActivity workoutMode = new WorkoutActivity();
                workoutMode.RunWorkoutActivity();
                workoutCount++;
                break;
                //quit
                case 5:
                    playing = false;
                    Console.Clear();
                    Console.WriteLine($"Great job! You completed the following activities:\nBreathing Activity: {breatheCount} times\nReflecting Activity: {reflectCount} times\nListing Activity: {listCount} times\nOne-minute workout: {workoutCount}\n\nThank you. Have a nice day! ");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                    Thread.Sleep(2000);
                    break;
            }
     
        }
    }
}