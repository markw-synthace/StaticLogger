using System;

namespace StaticLogger.Logging.Providers
{
    public class ConsoleLoggingProvider : ILoggingProvider
    {
        public void Info(string message) => Console.WriteLine($"INFO: {message}");

        public void Warn(string message) => Console.WriteLine($"WARNING: {message}");

        public void Error(string message) => Console.WriteLine($"ERROR: {message}");
    }
}
