using System.Runtime.ConstrainedExecution;

namespace Logging.AspNetCore;

public static class LogEntryBuilderExtensions
{
    public static LogEntryBuilder Action(this LogEntryBuilder builder, string action)
    {
        return builder.Append(AspNetCoreConstants.ACTION, action);
    }

    public static LogEntryBuilder Controller(this LogEntryBuilder builder, string controller)
    {
        return builder.Append(AspNetCoreConstants.CONTROLLER, controller);
    }

    public static LogEntryBuilder HttpMethod(this LogEntryBuilder builder, string httpMethod)
    {
        return builder.Append(AspNetCoreConstants.HTTPMETHOD, httpMethod);
    }

    public static LogEntryBuilder Page(this LogEntryBuilder builder, string page)
    {
        return builder.Append(AspNetCoreConstants.PAGE, page);
    }

    public static LogEntryBuilder User(this LogEntryBuilder builder, string user)
    {
        return builder.Append(AspNetCoreConstants.USER, user);
    }
}