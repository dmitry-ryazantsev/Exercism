namespace ResistorColorDuo;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] bandColors = new string[]
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

        if (colors.Length < 2)
            return -1;

        int firstBand = Array.IndexOf(bandColors, colors[0].ToLower());
        int secondBand = Array.IndexOf(bandColors, colors[1].ToLower());
        int twoBandResult = firstBand * 10 + secondBand;

        return twoBandResult;
    }
}