using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using Moq;
using Laughlin.Logging.Loggers;

namespace Laughlin.Logging.Tests
{
    [TestClass]
    public class Log4NetLoggingWrapperTests
    {
        [TestMethod]
        public void Write_SimpleInformationalMessage_Success()
        {
            // Arrange
            Mock<ILog> logMock = new Mock<ILog>();
            Log4NetLoggingWrapper loggingWrapper = new Log4NetLoggingWrapper(logMock.Object);
            LogMessage message = new LogMessage(LogLevel.Info, "Test Message");

            // Act
            loggingWrapper.Write(message);

            // Assert
            logMock.Verify(m => m.Info("Test Message"));
        }

        [TestMethod]
        public void Write_SimpleDebugMessage_Success()
        {
            // Arrange
            Mock<ILog> logMock = new Mock<ILog>();
            Log4NetLoggingWrapper loggingWrapper = new Log4NetLoggingWrapper(logMock.Object);
            LogMessage message = new LogMessage(LogLevel.Debug, "Test Message");

            // Act
            loggingWrapper.Write(message);

            // Assert
            logMock.Verify(m => m.Debug("Test Message"));
        }

        [TestMethod]
        public void Write_SimpleWarningMessage_Success()
        {
            // Arrange
            Mock<ILog> logMock = new Mock<ILog>();
            Log4NetLoggingWrapper loggingWrapper = new Log4NetLoggingWrapper(logMock.Object);
            LogMessage message = new LogMessage(LogLevel.Warning, "Test Message");

            // Act
            loggingWrapper.Write(message);

            // Assert
            logMock.Verify(m => m.Warn("Test Message"));
        }

        [TestMethod]
        public void Write_SimpleErrorMessage_Success()
        {
            // Arrange
            Mock<ILog> logMock = new Mock<ILog>();
            Log4NetLoggingWrapper loggingWrapper = new Log4NetLoggingWrapper(logMock.Object);
            LogMessage message = new LogMessage(LogLevel.Error, "Test Message");

            // Act
            loggingWrapper.Write(message);

            // Assert
            logMock.Verify(m => m.Error("Test Message"));
        }

        [TestMethod]
        public void Write_SimpleFatalMessage_Success()
        {
            // Arrange
            Mock<ILog> logMock = new Mock<ILog>();
            Log4NetLoggingWrapper loggingWrapper = new Log4NetLoggingWrapper(logMock.Object);
            LogMessage message = new LogMessage(LogLevel.Fatal, "Test Message");

            // Act
            loggingWrapper.Write(message);

            // Assert
            logMock.Verify(m => m.Fatal("Test Message"));
        }
    }
}
