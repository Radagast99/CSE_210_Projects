using System.IO;

public class Journal 
{
public List<Entry> _entries= new List<Entry>();
public string _file = "";

public Journal() 
{
}



public string Write(Entry newEntry, Prompt newPrompt) 
{   
    // calling the random prompt for the user to answer and
    // Passing to the Entry for the format
    string prompt = newPrompt.PromptRandom();
    string answer = Console.ReadLine();
    newEntry._prompt = prompt;
    newEntry._answer = answer;
    string promptAndAnswer = newEntry._prompt + newEntry._answer;
    return promptAndAnswer;
}

public void Display(string promptAndAnswer)
{
    foreach (Entry entry in _entries)
    {
        entry.Format();
    }

}

public void LoadToFile()
    {
        Console.WriteLine("What is the file name?");
        _file = Console.ReadLine();
        string[] readingFile = System.IO.File.ReadAllLines(_file);

        foreach (string line in readingFile)
        {
            string[] separatingArray = line.Split(",");
            string firstName = separatingArray[0];
            string lastName = separatingArray[1];
        }
    }

public void SaveToFile()
{   
    Console.WriteLine("What is the file name?");
    _file= Console.ReadLine();
    using (StreamWriter writeToFile = new StreamWriter(_file))
    {   
        foreach (Entry entry in _entries)
        {
            writeToFile.WriteLine(_entries);
            Console.WriteLine("");
        }
    }
}

}

