using System;

namespace StaticLogger.Logging.Providers
{
    public class UppercaseLoggingProvider : ILoggingProvider
    {
        public void Info(string message) => Console.WriteLine($"INFO: {message.ToUpper()}");

        public void Warn(string message) => Console.WriteLine($"WARNING: {message.ToUpper()}");

        public void Error(string message) => Console.WriteLine($"ERROR: {message.ToUpper()}");
    }
}
