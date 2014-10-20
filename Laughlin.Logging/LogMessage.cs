using System.Collections.Generic;

namespace Laughlin.Logging
{
    public class LogMessage
    {
        public LogMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
            Details = new Dictionary<string, string>();
        }

        public LogLevel Level { get; private set; }
        public string Message { get; private set; }
        public Dictionary<string, string> Details { get; private set; }
    }
}
