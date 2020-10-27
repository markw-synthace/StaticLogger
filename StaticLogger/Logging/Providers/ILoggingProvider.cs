namespace StaticLogger.Logging.Providers
{
    public interface ILoggingProvider
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
    }
}
