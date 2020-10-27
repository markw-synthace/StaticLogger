using StaticLogger.Logging;

namespace StaticLogger
{
    public class MainService
    {
        public void DoStuff()
        {
            // Note that no logger is injected, we just call the static methods on Logger
            Logger.Info("Doing stuff...");
            Logger.Warn("Whoa, stuff is happening");
            Logger.Error("I did not expect stuff to happen!!!");
            Logger.Info("Ignore that, it's all OK");
        }
    }
}
