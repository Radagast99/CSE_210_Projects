using System;

class Program
{
    static void Main(string[] args)
    {   //declaring the game loop variable 
        string gameContinue;
        do
        {
            // Creating the do while loop
            // declaring randomizer
            Random randomGenerator = new Random();
            // Declaring the variables for the random magic number
            int magicNumber = randomGenerator.Next(1, 101);
            // Declaring the variable for the guessNumber
            int guessNumber = 102;
            // doing the while loop
            while (guessNumber != magicNumber) 
            {   
                // asking user's guess
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                // creating conditions 
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber) 
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Asking user if wants to continue the game.
            Console.WriteLine("");
            Console.Write("Would you like to play again? ");
            gameContinue = Console.ReadLine();
        } while (gameContinue == "yes");
    } 
}

