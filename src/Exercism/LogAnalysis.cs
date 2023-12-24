public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Split(delimiter)[1];
    }

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
    {
        return str.Split(delimiter1)[1].Split(delimiter2)[0];
    }

    public static string Message(this string str)
    {
        return str.SubstringAfter(":").Trim();
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}