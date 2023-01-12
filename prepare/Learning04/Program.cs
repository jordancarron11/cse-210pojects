using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        List<int> ListOfNumbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0){
            Console.Write("Enter a number: type 0 to quit ");
            
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber != 0){
                ListOfNumbers.Add(userNumber);
            }
        }
        // Sum 
        int SumOfList = 0;
        foreach (int number in ListOfNumbers)
        {
            SumOfList += number;
        }

        Console.WriteLine($"Sum: {SumOfList}");
        // Average
        float average = ((float)SumOfList) / ListOfNumbers.Count;
        Console.WriteLine($"Avg: {average}");
        
        int maxNum = ListOfNumbers[0];

        //Max
        foreach (int number in ListOfNumbers){
            if (number > maxNum){
                maxNum = number;
            }
        }

        Console.WriteLine($"Max: {maxNum}");
    }
}