public class SeriLog : ILogger
{
    public void Save(string message)
    {
        Console.WriteLine($"Serilog ile log mesajı :{message}");
    }
}