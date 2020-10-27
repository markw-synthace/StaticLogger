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

            // Add all logging providers to the Logger
            var loggingProviders = services.GetServices<ILoggingProvider>();
            foreach (var provider in loggingProviders)
            {
                Logger.AddProvider(provider);
            }

            var service = services.GetService<MainService>();
            service.DoStuff();
        }

        private static ServiceProvider InitialiseServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainService>();
            services.AddSingleton<ILoggingProvider, ConsoleLoggingProvider>();
            services.AddSingleton<ILoggingProvider, UppercaseLoggingProvider>();

            return services.BuildServiceProvider();
        }
    }
}
