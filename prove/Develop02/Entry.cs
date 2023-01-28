using System;

public class Entry {
    public string userDate;
    public string userPrompt;
    public string userResponse;

    public void GenerateDate(){
        DateTime theCurrentTime = DateTime.Now;
        userDate = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt(){
        List<string> journalPrompts = new List<string>(){
       "What is something you did today that you are proud of?",
       "What is a piece of advice you learned today you want to share with your future self?",
       "Did you change anyones life today and if so how?", 
       "What did you daydream about today?", 
       "What task did you focus on today?", 
       "How did the Lord reach you today?",
        };
        Random random = new Random();
        int randomIndex = random.Next(journalPrompts.Count);
        userPrompt = journalPrompts[randomIndex];
        Console.WriteLine(userPrompt);
    }

    public void GetResponse(){
        Console.Write("Your Answer: ");
        userResponse = Console.ReadLine();
    }
}