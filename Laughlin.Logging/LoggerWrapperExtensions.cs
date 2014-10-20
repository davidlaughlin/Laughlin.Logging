using System;

namespace Laughlin.Logging
{
    public static class LoggingAdaptorExtensions
    {
        #region Basic Logging

        public static void LogInfo(this ILoggerWrapper loggingAdaptor, string message)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Info, message);
            loggingAdaptor.Write(logMessage);
        }

        public static void LogDebug(this ILoggerWrapper loggingAdaptor, string message)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Debug, message);
            loggingAdaptor.Write(logMessage);
        }

        public static void LogWarning(this ILoggerWrapper loggingAdaptor, string message)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Warning, message);
            loggingAdaptor.Write(logMessage);
        }

        public static void LogError(this ILoggerWrapper loggingAdaptor, string message)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Error, message);
            loggingAdaptor.Write(logMessage);
        }

        public static void LogFatal(this ILoggerWrapper loggingAdaptor, string message)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Fatal, message);
            loggingAdaptor.Write(logMessage);
        }

        #endregion Basic Logging

        public static void LogException(this ILoggerWrapper loggingAdaptor, Exception ex)
        {
            LogMessage logMessage = new LogMessage(LogLevel.Error, ex.Message);
            logMessage.Details.Add("StackTrace", ex.StackTrace);
            if (ex.InnerException != null)
            {
                LogException(loggingAdaptor, ex.InnerException);
            }

            loggingAdaptor.Write(logMessage);
        }
    }
}
