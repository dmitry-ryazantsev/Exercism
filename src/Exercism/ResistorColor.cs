namespace ResistorColor;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color.ToLower());

    public static string[] Colors()
    {
        return new string[]
            {
                "black",
                "brown",
                "red",
                "orange",
                "yellow",
                "green",
                "blue",
                "violet",
                "grey",
                "white"
            };
    }
}