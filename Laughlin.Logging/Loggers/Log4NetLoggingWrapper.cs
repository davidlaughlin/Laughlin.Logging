using System;
using System.ComponentModel;
using System.Diagnostics;
using log4net;

namespace Laughlin.Logging.Loggers
{
    public class Log4NetLoggingWrapper : ILoggerWrapper
    {
        #region Variables

        private readonly ILog _logger;

        #endregion Variables

        #region Constructors

        public Log4NetLoggingWrapper(ILog logger)
        {
            _logger = logger;
        }

        public Log4NetLoggingWrapper(Type type)
        {
            _logger = LogManager.GetLogger(type);
        }

        public Log4NetLoggingWrapper(string name)
        {
            _logger = LogManager.GetLogger(name);
        }

        #endregion Constructors

        #region Methods

        public void Write(LogMessage message)
        {
            switch (message.Level)
            {
                case LogLevel.Info:
                    _logger.Info(message.Message);
                    break;
                case LogLevel.Debug:
                    _logger.Debug(message.Message);
                    break;
                case LogLevel.Warning:
                    _logger.Warn(message.Message);
                    break;
                case LogLevel.Error:
                    _logger.Error(message.Message);
                    break;
                case LogLevel.Fatal:
                    _logger.Fatal(message.Message);
                    break;
                default:
                    throw new InvalidEnumArgumentException(message.Level.ToString());
            }
        }

        #endregion Methods

    }
}
