public class Activities
{
    protected string _welcome = "";
    protected string _instructions = "";

    public Activities()
    {

    }

    public Activities(string welcome, string instructions)
    {
        _welcome = welcome;
        _instructions = instructions;
    }

    public string GetWelcome()
    {
        return _welcome;
    }

    public string GetInstructions()
    {
        return _instructions;
    }

    public string GetStarted()
    {
        return _welcome + 
               _instructions;
    }
}