using Microsoft.Extensions.Logging;

namespace Logging
{
    public class LoggingContext<T> : IDisposable
    {
        private readonly ILogger<T> _logger;
        private readonly LogEntryBuilder _logEntry;

        public LogLevel LogLevel { get; set; } = LogLevel.Information;

        public LoggingContext(ILogger<T> logger, LogEntryBuilder logEntry)
        {
            _logger = logger;
            _logEntry = logEntry;
        }

        public void Dispose()
        {
            _logger.Log(LogLevel, _logEntry.ToString());
        }
    }
}