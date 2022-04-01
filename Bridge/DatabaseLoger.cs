using BridgeDesignPattern;

public class DatabaseLoger : Logger
{
    public DatabaseLoger(ILogger _logger)
    {
        this.logger = _logger;
    }

    public override void Log(string message)
    {
        Console.WriteLine($"Dosyaya {this.logger} ile '{message}' mesajı loglandı");
    }
}