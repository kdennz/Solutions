using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startPos = logLine.IndexOf('[') + 1;
        int length = logLine.IndexOf(']') - startPos;
        return logLine.Substring(startPos, length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}