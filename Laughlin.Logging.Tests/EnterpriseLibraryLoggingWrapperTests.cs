//using System;
//using Laughlin.Logging.Loggers;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Laughlin.Logging.Tests
//{
//    [TestClass]
//    public class EnterpriseLibraryLoggingWrapperTests
//    {
//        [TestMethod]
//        public void Write_SimpleInformationalMessage_Success()
//        {
//            EnterpriseLibraryLoggingWrapper logger = new EnterpriseLibraryLoggingWrapper();
//            LogMessage message = new LogMessage(LogLevel.Info, "Test Message");
//            logger.Write(message);
//        }

//        [TestMethod]
//        public void Write_SimpleDebugMessage_Success()
//        {
//            EnterpriseLibraryLoggingWrapper logger = new EnterpriseLibraryLoggingWrapper();
//            LogMessage message = new LogMessage(LogLevel.Debug, "Test Message");
//            logger.Write(message);
//        }

//        [TestMethod]
//        public void Write_SimpleWarningMessage_Success()
//        {
//            EnterpriseLibraryLoggingWrapper logger = new EnterpriseLibraryLoggingWrapper();
//            LogMessage message = new LogMessage(LogLevel.Warning, "Test Message");
//            logger.Write(message);
//        }

//        [TestMethod]
//        public void Write_SimpleErrorMessage_Success()
//        {
//            EnterpriseLibraryLoggingWrapper logger = new EnterpriseLibraryLoggingWrapper();
//            LogMessage message = new LogMessage(LogLevel.Error, "Test Message");
//            logger.Write(message);
//        }

//        [TestMethod]
//        public void Write_SimpleFatalMessage_Success()
//        {
//            EnterpriseLibraryLoggingWrapper logger = new EnterpriseLibraryLoggingWrapper();
//            LogMessage message = new LogMessage(LogLevel.Fatal, "Test Message");
//            logger.Write(message);
//        }
//    }
//}
