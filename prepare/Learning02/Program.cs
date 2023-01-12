using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("What grade did you get in the class? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        if (grade >= 90){
            letter = ("A");
        }

        else if (grade >=80 ){
            letter = ("B");
        }
        
        else if (grade >=70 ){
            letter = ("C");
        }
        else if (grade >=60 ){
            letter = ("D");
        }
        else{
            letter = ("F");
        }
        
        Console.Write("your grade is: ");
        Console.WriteLine(letter);


        if (grade >= 70){
            Console.WriteLine("Congratulations you passed!");
        }
        else{
            Console.WriteLine("Unfortunately you failed. Good luck next time!");
        }
        
    }

   
}