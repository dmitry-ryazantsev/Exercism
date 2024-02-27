using System.Text;

namespace SqueakyClean;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterHyphen = false;
        foreach (char c in identifier)
        {
            sb.Append(c switch
            {
                _ when isAfterHyphen => char.ToUpper(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) && !IsGreekLowercase(c) => c,
                _ => string.Empty,
            });

            isAfterHyphen = c.Equals('-');
        }

        return sb.ToString();
    }
}