using System.Text;
using Barotrauma;

namespace MyModName;

public static class Logging
{
#if DEBUG
    public static LoggingLevel LogLevel = LoggingLevel.Trace;
#else
    public static LoggingLevel LogLevel = LoggingLevel.Warn;
#endif

    public static void Trace(string msg)
    {
        ModUtils.Logging.PrintMessage($"[{Plugin.ShortName}] [Trace] {msg}");
    }
    public static void Info(string msg)
    {
        ModUtils.Logging.PrintMessage($"[{Plugin.ShortName}] [Info] {msg}");
    }
    public static void Warn(string msg)
    {
        ModUtils.Logging.PrintWarning($"[{Plugin.ShortName}] [Warn] {msg}");
    }
    public static void Error(string msg, Exception? ex = null)
    {
        var sb = new StringBuilder(msg);
        if (ex != null)
        {
            sb.Append($"Exception: {ex.Message}");
            sb.Append($"Stack trace: {ex.StackTrace}");
        }
        ModUtils.Logging.PrintError($"[{Plugin.ShortName}] [Error] {sb}");
    }
}
public enum LoggingLevel : byte
{
    Disabled,
    Error,
    Warn,
    Info,
    Trace
}