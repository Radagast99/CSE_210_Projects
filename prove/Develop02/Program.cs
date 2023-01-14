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

            // calling Journal class
            Journal userJournal = new Journal();
            //Based on conditions we need to process what he wants to do.
            if (userChoice == 1)
            {
                userJournal.Write();   
            } 
            else if (userChoice == 2)
            { 
                userJournal.Display();
            }
            else if (userChoice == 3) 
            {
                userJournal.LoadToFile();
            }
            else if (userChoice == 4)
            {
                userJournal.SaveToFile();
            }
        }while(userChoice != 7);
    }
}