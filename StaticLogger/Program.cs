using System;
using Microsoft.Extensions.DependencyInjection;
using StaticLogger.Logging;
using StaticLogger.Logging.Providers;

namespace StaticLogger
{
    internal static class Program
    {
        private static void Main()
        {
            var services = InitialiseServices();

            // Call this right up here at top level, before we kick off the root service
            InitialiseLogger(services);

            var service = services.GetService<MainService>();
            service.DoStuff();
        }

        private static void InitialiseLogger(IServiceProvider services)
        {
            // Add all logging providers to the Logger
            var loggingProviders = services.GetServices<ILoggingProvider>();
            foreach (var provider in loggingProviders)
            {
                Logger.AddProvider(provider);
            }
        }

        private static IServiceProvider InitialiseServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainService>();
            services.AddSingleton<ILoggingProvider, ConsoleLoggingProvider>();
            services.AddSingleton<ILoggingProvider, UppercaseLoggingProvider>();

            return services.BuildServiceProvider();
        }
    }
}
