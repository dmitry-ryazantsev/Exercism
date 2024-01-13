[TestFixture]
public class BirdCountTests
{
    [Test]
    public void LastWeek_ReturnsAnExpectedArray()
    {
        int[] lastWeekBirds = new int[] { 0, 2, 5, 3, 7, 8, 4 };
        Assert.That(BirdCount.LastWeek(), Is.EqualTo(lastWeekBirds));
    }

    [Test]
    public void Today_ReturnsTheLastElementOfAnArray()
    {
        int[] counts = new int[] { 8, 8, 9, 5, 4, 7, 10 };
        int lastElement = counts[^1];
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.Today(), Is.EqualTo(lastElement));
    }

    [Test]
    public void IncrementTodaysCount_IncrementsTheLastElementOfAnArray()
    {
        int[] counts = new int[] { 8, 8, 9, 5, 4, 7, 6 };

        BirdCount birdCount = new BirdCount(counts);
        birdCount.IncrementTodaysCount();

        int lastElement = counts[^1];

        Assert.That(birdCount.Today(), Is.EqualTo(lastElement));
    }

    [Test]
    public void HasDayWithoutBirds_WithDaysWithoutBirds()
    {
        int[] counts = new int[] { 8, 0, 9, 5, 4, 7, 6 };
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.HasDayWithoutBirds(), Is.True);
    }

    [Test]
    public void HasDayWithoutBirds_NoDaysWithoutBirds()
    {
        int[] counts = new int[] { 8, 3, 9, 5, 4, 7, 6 };
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.HasDayWithoutBirds(), Is.False);
    }

    [Test]
    public void CountForFirstDays_FirstThreeDaysOfDisappointingWeek()
    {
        int[] counts = new int[] { 0, 1, 1, 0, 1, 2, 1 };
        int birdsInFirstThreeDays = 2;
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.CountForFirstDays(3), Is.EqualTo(birdsInFirstThreeDays));
    }

    [Test]
    public void CountForFirstDays_FirstFiveDaysOfGreatWeek()
    {
        int[] counts = new int[] { 5, 8, 4, 9, 6, 7, 4 };
        int birdsInFirstFiveDays = 32;
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.CountForFirstDays(5), Is.EqualTo(birdsInFirstFiveDays));
    }

    [Test]
    public void BusyDays_DisappointingWeek()
    {
        int[] counts = new int[] { 0, 1, 1, 0, 1, 2, 1 };
        int busyDays = 0;
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.BusyDays(), Is.EqualTo(busyDays));
    }

    [Test]
    public void BusyDays_GreatWeek()
    {
        int[] counts = new int[] { 5, 8, 4, 9, 6, 7, 4 };
        int busyDays = 5;
        BirdCount birdCount = new BirdCount(counts);

        Assert.That(birdCount.BusyDays(), Is.EqualTo(busyDays));
    }
}