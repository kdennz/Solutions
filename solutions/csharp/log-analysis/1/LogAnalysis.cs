using System;

public static class LogAnalysis
{
    // Task 1: SubstringAfter extension method
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Split(delimiter)[1];
    }

    // Task 2: SubstringBetween extension method
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        return str.Split(startDelimiter)[1].Split(endDelimiter)[0];
    }

    // Task 3: Message extension method
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // Task 4: LogLevel extension method
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}