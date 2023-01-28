using System;
//Only Basic Requirements
class Program{
    static void Main(string[] args){

        Journal journal = new Journal();
        bool keepGoing = true;
        while (keepGoing){
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Option Number: ");
            int userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();





            switch (userChoice){   
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Name of File: ");
                    string loadUserFilename = Console.ReadLine();
                    journal.LoadEntries(loadUserFilename);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Name of File: ");
                    string saveUserFilename = Console.ReadLine();
                    journal.SaveEntries(saveUserFilename);
                    Console.WriteLine("Saved!\n");
                    break;
                case 5:
                    keepGoing = false;
                    Console.WriteLine("Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid input Choose from this list:");
                    break;
            }
        }
    }
}