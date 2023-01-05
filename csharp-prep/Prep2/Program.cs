using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage here: ");
        string grade = Console.ReadLine();

        int gradePer = int.Parse(grade);

        string letter = "";

        if (gradePer >= 90)
        {
            letter = "A";
        }
        else if (gradePer >= 80)
        {
            letter = "B";
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if (gradePer >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write($"Your score is: {letter}");

        if (gradePer >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
             Console.WriteLine("I hope you can have a better grade in the future");
        }

    }   

}