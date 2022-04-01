public class Log4Net : ILogger
{
    public void Save(string message)
    {
        Console.WriteLine($"Log4Net ile log mesajı :{message}");
    }
}