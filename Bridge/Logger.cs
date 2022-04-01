namespace BridgeDesignPattern
{
    public abstract class Logger
    {
        protected ILogger logger;

        public abstract void Log(string message);
    }
}