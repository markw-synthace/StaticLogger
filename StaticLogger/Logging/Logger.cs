using System.Collections.Generic;
using StaticLogger.Logging.Providers;

namespace StaticLogger.Logging
{
    public static class Logger
    {
        private static readonly List<ILoggingProvider> LoggingProviders = new List<ILoggingProvider>();

        public static void AddProvider(ILoggingProvider provider) => LoggingProviders.Add(provider);
        public static void RemoveAllProviders() => LoggingProviders.Clear();
        public static void Info(string message) => LoggingProviders.ForEach(provider => provider.Info(message));
        public static void Warn(string message) => LoggingProviders.ForEach(provider => provider.Warn(message));
        public static void Error(string message) => LoggingProviders.ForEach(provider => provider.Error(message));
    }
}
