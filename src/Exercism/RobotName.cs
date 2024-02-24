public class Robot
{
    // It's important for the list to be static to be shared among all instances
    private static List<string> robotIds = new List<string>();
    private static Random random = new Random();
    private string id = string.Empty;

    public string Name
    {
        get
        {
            if (id == string.Empty)
            {
                GenerateUniqueName();
            }

            return id;
        }
    }

    private string GenerateUniqueName()
    {
        do
        {
            char letter1 = (char)('A' + random.Next(0, 26));
            char letter2 = (char)('A' + random.Next(0, 26));

            string number = random.Next(0, 1000).ToString("D3");

            id = $"{letter1}{letter2}{number}";
        } while (robotIds.Contains(id));


        robotIds.Add(id);
        return id;
    }

    public void Reset()
    {
        id = string.Empty;
    }
}