using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomMessage();
        
        string name = GetUserName();
        int number = UserNumber();

        int squarednum = SquaredNumber(number);

        Result(name, squarednum);
    }
// Welcome message function
    static void WelcomMessage(){
        Console.WriteLine("Welcome to the Squared Number Calculator!");
    }

//Username function
    static string GetUserName(){
        Console.Write("Please enter your UserName: ");
        string userName = Console.ReadLine();

        return userName;
    }
// users Integer function 
static int UserNumber(){
    Console.Write("Enter a number: ");
    int userNum = int.Parse(Console.ReadLine());

    return userNum;
}
// Converts Int to the number ^2
static int SquaredNumber(int number){
    int square = number * number;
    
    return square;
}
static void Result (string name, int number){
    Console.WriteLine($"{name} your number squared is: {number}");
}


}