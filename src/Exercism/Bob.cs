namespace Bob;

public static class Bob
{
    public static string Response(string statement)
    {
        if (IsSilence(statement))
        {
            return "Fine. Be that way!";
        }

        if (IsYell(statement) && IsQuestion(statement))
        {
            return "Calm down, I know what I'm doing!";
        }

        if (IsYell(statement))
        {
            return "Whoa, chill out!";
        }

        if (IsQuestion(statement))
        {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsSilence(string statement)
    {
        return string.IsNullOrWhiteSpace(statement);
    }

    private static bool IsQuestion(string statement)
    {
        return statement.Trim().EndsWith('?');
    }

    private static bool IsYell(string statement)
    {
        return statement.Any(char.IsLetter) && statement.ToUpper() == statement;
    }
}