public class Entry
{   public string _prompt = "";
    public string _answer = "";
    DateTime _date = DateTime.Now;

    public Entry()
    {
    }

    public void Format()
    {
        string dateToString = _date.ToShortDateString();
        Console.WriteLine($"Date: {dateToString} - Prompt: {_prompt}\n{_answer}");
    }   
}