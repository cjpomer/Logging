namespace Logging
{
    // public class LoggingContextMiddleware
    // {
    //     private readonly RequestDelegate _next;

    //     public LoggingContextMiddleware(RequestDelegate next)
    //     {
    //         _next = next;
    //     }

    //     // IMessageWriter is injected into InvokeAsync
    //     public async Task InvokeAsync(HttpContext httpContext, ILogger<LoggingContextMiddleware> logger, LogEntryBuilder logEntry)
    //     {
    //         logEntry.StartTime(DateTimeOffset.Now);
    //         using (new LoggingContext<LoggingContextMiddleware>(logger, logEntry))
    //         using (logEntry.CreateDuration_ms())
    //         {
    //             await _next(httpContext);
    //         }
    //     }
    // }

    // public static class LoggingExtensions
    // {
    //     public static IApplicationBuilder UseLoggingContext(this IApplicationBuilder builder)
    //     {
    //         return builder.UseMiddleware<LoggingContextMiddleware>();
    //     }
    // }
}