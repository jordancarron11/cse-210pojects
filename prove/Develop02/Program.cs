using System;
//Only Basic Requirements
class Program{
    static void Main(string[] args){
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;
        while (running){
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Option Number: ");
            int choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice){   
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter the name of the file: ");
                    string loadUserFilename = Console.ReadLine();
                    journal.LoadEntries(loadUserFilename);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter the name of the file: ");
                    string saveUserFilename = Console.ReadLine();
                    journal.SaveEntries(saveUserFilename);
                    Console.WriteLine("Saved!\n");
                    break;
                case 5:
                    running = false;
                    Console.WriteLine("Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following choices.");
                    break;
            }
        }
    }
}