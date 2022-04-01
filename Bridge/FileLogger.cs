using BridgeDesignPattern;

public class FileLogger : Logger
{
    public FileLogger(ILogger _logger)
    {
        this.logger = _logger;
    }

    public override void Log(string message)
    {
        Console.WriteLine($"Dosyaya {this.logger} ile '{message}' mesajı loglandı");
    }
}