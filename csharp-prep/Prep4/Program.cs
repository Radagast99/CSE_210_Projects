using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {   // declaring variable for do-while
        int listFinisher;
        // creating list and program instructions.
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // declaring the do-while loop.
        do 
        {   
            // asking a number to the user.
            Console.Write("Enter a number: ");
            listFinisher = int.Parse(Console.ReadLine());
            //exclude the zero from the list
            if (listFinisher != 0)
            {
                numberList.Add(listFinisher);
            }

        } while (listFinisher != 0);
        // computing the list sum.
        int total = numberList.Sum();
        Console.WriteLine($"The sum is: {total}"); 
        // computing the average number from the list.
        int listLen = numberList.Count;
        float average = total / listLen;
        Console.WriteLine($"The average is: {average}");
        // computing the largest number from te list.
        int largestNum = numberList.Max();
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}