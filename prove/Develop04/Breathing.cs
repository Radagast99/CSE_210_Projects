public class Breathing : 
{
    
    protected int _duration = 0;

    
    public Breathing()
    {

    }

    public Breathing(string welcome, string instructions,int duration) 
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }


}