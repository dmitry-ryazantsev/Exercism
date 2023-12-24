using System.Text.RegularExpressions;

static class LogLine
{
    // returns a text after a colon
    public static string Message(string logLine)
    {
        string messagePattern = ":(.+)";
        return Regex.Match(logLine, messagePattern).Groups[1].Value.Trim();
    }

    // returns a text inside square brackets
    public static string LogLevel(string logLine)
    {
        string logLevelPattern = @"\[(.+)\]:";
        return Regex.Match(logLine, logLevelPattern).Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}