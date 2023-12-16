using Microsoft.Extensions.Logging;

namespace Logging
{
    public struct LoggingContext<T> : IDisposable
    {
        private readonly ILogger<T> _logger;
        private readonly LogEntryBuilder _logEntry;

        public LoggingContext(ILogger<T> logger, LogEntryBuilder logEntry)
        {
            _logger = logger;
            _logEntry = logEntry;
        }

        public void Dispose()
        {
            _logger.Log(_logEntry.LogLevel, _logEntry.ToString());
        }
    }
}