using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("958 Westwood Drive", "Jefferson", "MO", "65109", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Missonary Fairwell", "Jordan Carron is giving his mission fairwell for the church of Jesus Christ of Latter-Day Saints", "May, 2021", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Carron", 400);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("1122 Main Street", "South Jordan", "UT", "84604", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Maren and Jordan", "Please join Maren and Jordan for their reception this evening", "December 21, 2021", "6:00 pm - 9:00pm", $"{receptionAddress}", "Reception", "mr&mrscarron@gmail.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("895 fremont St", "Vegas", "NV", "79777", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Hackathon", "City wide hackathon for Las Vegas", "February 3, 2022", "8:00 am - 9:00 pm", $"{outdoorAddress}", "Outdoor", "Cloudy");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}