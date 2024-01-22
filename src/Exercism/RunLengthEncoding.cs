using System.Text;

namespace RunLengthEncoding;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            int count = 1;

            // Count consecutive occurrences
            while (i + 1 < input.Length && input[i] == input[i + 1])
            {
                count++;
                i++;
            }

            result.Append(count > 1 ? count.ToString() : "");
            result.Append(input[i]);
        }

        return result.ToString();
    }

    public static string Decode(string input)
    {
        StringBuilder result = new StringBuilder();
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                count = count * 10 + int.Parse(input[i].ToString()); // Accumulate digit values
            }
            else
            {
                if (count == 0)
                {
                    count = 1; // If no digit precedes the character, set count to 1
                }

                result.Append(new string(input[i], count));
                count = 0; // Reset count for the next character
            }
        }

        return result.ToString();
    }
}