using System.IO;

public class Journal 
{
public List<Entry> _entries= new List<Entry>();
public string _file = "";

public Journal() 
{
}

Entry newEntry = new Entry();
Prompt newPrompt = new Prompt();
public void Write() 
{   
    // calling the random prompt for the user to answer
    string promptToEntry = newPrompt.PromptRandom();
    string answerToEntry = Console.ReadLine();
    // Giving the format that needs to e
    string promptAndAnswer = newEntry.StoringEntry(promptToEntry, answerToEntry);
}

public void SaveToFile()
{   
    Console.WriteLine("What is the file name?");
    _file= Console.ReadLine();
    using (StreamWriter writeToFile = new StreamWriter(_file))
    {   
       
        foreach (Entry entry in _entries)
        writeToFile.WriteLine(_entries);
    }

}

public void LoadToFile()
{
    
}

public void EditFromFile()
{
    
}

public void DeleteFromFile()
{
    
}
}

