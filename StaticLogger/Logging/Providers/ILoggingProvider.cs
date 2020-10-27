namespace StaticLogger.Logging.Providers
{
    /// <summary>
    /// A VERY simple logging interface. A real logger would do more useful things like logging exceptions etc.
    /// </summary>
    public interface ILoggingProvider
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
    }
}
