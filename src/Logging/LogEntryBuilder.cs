using System.Diagnostics;
using System.Text;

namespace Logging
{
    public class LogEntryBuilder
    {
        private class LogEntryDuration : IDisposable
        {
            private readonly LogEntryBuilder _builder;
            private readonly string _key;
            readonly Stopwatch _stopwatch;

            public LogEntryDuration(LogEntryBuilder builder, string key)
            {
                _builder = builder;
                _key = key;
                _stopwatch = new Stopwatch();
                _stopwatch.Start();
            }

            public void Dispose()
            {
                _stopwatch.Stop();
                _builder.Duration_ms(_key, _stopwatch.ElapsedMilliseconds);
            }
        }
        readonly StringBuilder _builder;

        public LogEntryBuilder()
        {
            _builder = new StringBuilder();
        }

        public static implicit operator string(LogEntryBuilder builder) => builder.ToString();

        public LogEntryBuilder Append(string key, string value)
        {
            _builder.Append($"{key}={value} ");
            return this;
        }

        public IDisposable CreateDuration_ms(string key="duration_ms")
        {
            return new LogEntryDuration(this, key);
        }

        public LogEntryBuilder Duration_ms(string key, long duration_ms)
        {
            return Append(key.EndsWith("_ms") ? key : $"{key}_ms", duration_ms.ToString());
        }

        public LogEntryBuilder Duration_ms(long duration_ms)
        {
            return Duration_ms("duration_ms", duration_ms);
        }

        public LogEntryBuilder Exception(string exception)
        {
            return Append("exception", exception);
        }

        public LogEntryBuilder Org(string orgId)
        {
            return Append("org", orgId);
        }

        public LogEntryBuilder StartTime(DateTimeOffset startTime)
        {
            return Append("startTime", startTime.ToString("u"));
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}