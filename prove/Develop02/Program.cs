using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        do 
        {   
            // Providing options to the user
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Edit Prompt");
            Console.WriteLine("6. Delete Prompt");
            Console.WriteLine("7. Quit");

            //Asking what is the choice
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            // calling all the classes
            Entry newEntry = new Entry();
            Prompt newPrompt = new Prompt();
            Journal userInput = new Journal();
            //Based on conditions we need to process what he wants to do.
            if (userChoice == 1)
            {
                userInput.Write();
                    
            } else if (userChoice == 2)
            { 

            }
        }while(userChoice != 7);
    }
}