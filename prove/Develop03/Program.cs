using System;
class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        while (playAgain == "" && playAgain != "quit"){   

        //different scriptures I am using in the menu
            Reference book1 = new Reference("James 1:5");
            Scripture verse1 = new Scripture(book1, "If any of you lacks wisdom, you should ask God, who gives generously to all without finding fault, and it will be given to you.");
            Memorize memorize1 = new Memorize(verse1);

            Reference Reference2 = new Reference("John 16:33");
            Scripture verse2 = new Scripture(Reference2, "In the world you will have tribulation. But take heart; I have overcome the world.");
            Memorize memorize2 = new Memorize(verse2);

            Reference Reference3 = new Reference("Proverbs 3:5-6");
            Scripture verse3 = new Scripture(Reference3, "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths.");
            Memorize memorize3 = new Memorize(verse3);
        // the menu along with the request to choose one of them 
            string menu = string.Format("1. {0}\n2. {1}\n3. {2}\n4. quit", book1.toString(), Reference2.toString(), Reference3.toString());
            string userInput = "";
            Console.Write($"Which verse do you want to memorize?\n{menu}\n->");
            int number = int.Parse(Console.ReadLine());



            while (userInput != "quit"){
                if (number == 1){
                Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", book1.toString(), memorize1.toString()));
                Console.WriteLine("To continue press enter or type 'quit': ");
                userInput = Console.ReadLine();
                memorize1.removeWordsFromText();
                    if (memorize1.hasWordsLeft() == false){
                        userInput = "quit";
                    }
                }
                else if (number == 2){
                Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", Reference2.toString(), memorize2.toString()));
                Console.WriteLine("To continue press enter or type 'quit': ");
                userInput = Console.ReadLine();
                memorize2.removeWordsFromText();
                    if (memorize2.hasWordsLeft() == false){
                        userInput = "quit";
                    }
                }
                else if (number ==3){
                Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", Reference3.toString(), memorize3.toString()));
                Console.WriteLine("To continue press enter or type 'quit': ");
                userInput = Console.ReadLine();
                memorize3.removeWordsFromText();
                    if (memorize3.hasWordsLeft() == false){
                        userInput = "quit";
                    } 
                }
                else if (number == 4){
                    userInput = "quit";
                    playAgain = "quit";
                }
                else{
                    Console.WriteLine($"That is an invalid option please choose from {menu}");
                }
            }
            if (number == 1){
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", book1.toString(), memorize1.toString()));
            }
            else if (number == 2){
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", Reference2.toString(), memorize2.toString()));
            }
            else if (number == 3){
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", Reference3.toString(), memorize3.toString()));
            }
        if (number != 4){
        Console.WriteLine("\nGood job!\n To learn another verse press enter else type 'quit': ");
        playAgain = Console.ReadLine();
        }
        else{
            playAgain = "quit";
        }
        }
    Console.WriteLine("Thank you for learning with us!");
    }
}