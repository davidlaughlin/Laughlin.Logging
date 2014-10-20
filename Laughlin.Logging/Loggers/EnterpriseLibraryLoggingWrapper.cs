//using System.ComponentModel;
//using System.Diagnostics;
//using Microsoft.Practices.EnterpriseLibrary.Logging;

//namespace Laughlin.Logging.Loggers
//{
//    public class EnterpriseLibraryLoggingWrapper : ILoggerWrapper
//    {
//        public EnterpriseLibraryLoggingWrapper()
//        {
            
//        }

//        public void Write(LogMessage message)
//        {
//            Write("Default", message);
//        }

//        public void Write(string category, LogMessage message)
//        {
//            switch (message.Level)
//            {
//                case LogLevel.Info:
//                    _logger.Info(message.Message);
//                    break;
//                case LogLevel.Debug:
//                    _logger.Debug(message.Message);
//                    break;
//                case LogLevel.Warning:
//                    _logger.Warn(message.Message);
//                    break;
//                case LogLevel.Error:
//                    _logger.Error(message.Message);
//                    break;
//                case LogLevel.Fatal:
//                    _logger.Fatal(message.Message);
//                    break;
//                default:
//                    throw new InvalidEnumArgumentException(message.Level.ToString());
//            }
//        }
//    }
//}
