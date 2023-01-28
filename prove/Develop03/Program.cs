using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRef = new Reference("Proverbs", "3", "5-6");
        Scripture scriptureText = new Scripture(scriptureRef, "Trust in the Lord with all thine heart; and lean not unto thine own understanding;" +
                                                              " In all thy ways acknowledge him, and he shall direct thy paths.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scriptureText);

        string input = "";

        while (input != "quit" && scriptureMemorizer.NothingLeftOut() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureRef.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            Console.ReadLine();
            scriptureMemorizer.WordsRemover();
        }
    }
}