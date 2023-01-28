using System;

public class Journal
{

    public List<Entry> userEntries = new List<Entry>();
    public void NewEntry(){
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();
        userEntries.Add(userEntry);
    }

    public void DisplayEntries(){
        foreach (Entry entry in userEntries){
            Console.WriteLine($"\nDate: {entry.userDate} \nPrompt: {entry.userPrompt} \nResponse: {entry.userResponse}\n");
        }
    }
    public void SaveEntries(string userFilename){
        using (StreamWriter outputFile = new StreamWriter(userFilename, true)){
            foreach (Entry entry in userEntries){
                outputFile.WriteLine($"Date:{entry.userDate}: {entry.userPrompt}\n{entry.userResponse}\n");
            }
        }
    }
    public void LoadEntries(string userFilename){
        using (StreamReader reader = new StreamReader(userFilename)){
            String journalEntries = reader.ReadToEnd();
            Console.Write(journalEntries);
        }
    } 
}