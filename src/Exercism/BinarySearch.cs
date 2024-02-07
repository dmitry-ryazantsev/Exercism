namespace BinarySearch;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Array.Sort(input);

        int low = 0;
        int high = input.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (input[mid] == value)
                return mid;

            else if (input[mid] > value)
                high = mid - 1;

            else
                low = mid + 1;
        }

        return -1;
    }
}