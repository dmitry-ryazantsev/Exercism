public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
                return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
                busyDays++;
        }

        return busyDays;
    }
}