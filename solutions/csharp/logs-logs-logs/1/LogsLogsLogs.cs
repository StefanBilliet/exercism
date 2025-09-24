// TODO: define the 'LogLevel' enum

using System.Text.RegularExpressions;

static partial class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        var match = MyRegex().Match(logLine);
        if (match.Success)
        {
            return match.Groups[1].Value switch
            {
                "TRC" => LogLevel.Trace,
                "DBG" => LogLevel.Debug,
                "INF" => LogLevel.Info,
                "WRN" => LogLevel.Warning,
                "ERR" => LogLevel.Error,
                "FTL" => LogLevel.Fatal,
                _ => LogLevel.Unknown
            };
        }

        return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }

    [GeneratedRegex(@"\[(.*?)\]")]
    private static partial Regex MyRegex();
}

internal enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}