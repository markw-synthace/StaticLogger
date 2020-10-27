using NSubstitute;
using NUnit.Framework;
using StaticLogger.Logging;
using StaticLogger.Logging.Providers;

namespace StaticLogger.Tests
{
    public class MainServiceTests
    {
        private ILoggingProvider _mockLoggingProvider;
        private MainService _mainService;

        [SetUp]
        public void SetUp()
        {
            _mockLoggingProvider = Substitute.For<ILoggingProvider>();
            _mainService = new MainService();
        }

        [TearDown]
        public void TearDown()
        {
            Logger.RemoveAllProviders();
        }

        [Test]
        public void GivenLoggerIsAdded_WhenDoStuffIsCalled_ThenMessagesAreLogged()
        {
            // Given
            Logger.AddProvider(_mockLoggingProvider);

            // When
            _mainService.DoStuff();

            // Then
            _mockLoggingProvider.Received(1).Info("Doing stuff...");
            _mockLoggingProvider.Received(1).Warn("Whoa, stuff is happening");
            _mockLoggingProvider.Received(1).Error("I did not expect stuff to happen!!!");
            _mockLoggingProvider.Received(1).Info("Ignore that, it's all OK");
        }
    }
}
