namespace SumOfMultiples;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> numbers = new List<int>();

        foreach (int baseValue in multiples)
        {
            if (baseValue == 0)
                continue;

            int multiple = baseValue;

            while (multiple < max)
            {
                numbers.Add(multiple);
                multiple += baseValue;
            }
        }

        numbers = numbers.Distinct().ToList();
        return numbers.Sum();
    }
}