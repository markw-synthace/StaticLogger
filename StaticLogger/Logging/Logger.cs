using System.Collections.Generic;
using StaticLogger.Logging.Providers;

namespace StaticLogger.Logging
{
    /// <summary>
    /// A static logger to be used throughout the project.
    ///
    /// Because it's static, it's easy to use and doesn't need to be injected into every class.
    ///
    /// If no providers are added it does nothing, so it won't break unit tests.
    /// </summary>
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
