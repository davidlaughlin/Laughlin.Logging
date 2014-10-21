namespace Laughlin.Logging.Loggers
{
    public class NullLoggingWrapper : ILoggerWrapper
    {
        public void Write(LogMessage message)
        {
            // Do nothing
        }
    }
}
