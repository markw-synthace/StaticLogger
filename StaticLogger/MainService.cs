using StaticLogger.Logging;

namespace StaticLogger
{
    public class MainService
    {
        public void DoStuff()
        {
            // Note, no logger injected
            Logger.Info("Doing stuff...");
            Logger.Warn("Whoa, stuff is happening");
            Logger.Error("I did not expect stuff to happen!!!");
            Logger.Info("Ignore that, it's all OK");
        }
    }
}
