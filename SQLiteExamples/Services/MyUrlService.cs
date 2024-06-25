namespace SQLiteExamples.Services;

public class MyUrlService
{
    public string Url { get; set; }

    public MyUrlService(string url)
    {
        Url = url;
    }
}