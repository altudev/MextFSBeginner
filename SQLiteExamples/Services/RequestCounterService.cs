namespace SQLiteExamples.Services;

public class RequestCounterService
{
    private int _counter = 0;
    
    public void Increment()
    {
        _counter++;
    }
    
    public int Get()
    {
        return _counter;
    }
}