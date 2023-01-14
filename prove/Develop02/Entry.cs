public class Entry
{   public List<string> _promptAndAswer = new List<string>();
    DateTime _date = DateTime.Now;

    public Entry()
    {
    }

    public string StoringEntry(string _prompt, string _answer)
    {
        string dateToString = _date.ToShortDateString();
        string showing = @"Date:" + dateToString + "- Prompt: " + _prompt
                           + _answer;
        _promptAndAswer.Add(showing);
        return showing;
    }   
}