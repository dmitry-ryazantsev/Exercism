using NUnit.Framework;

[TestFixture]
public class AssemblyLineTests
{
    [Test]
    public void SuccessRateTest()
    {
        Assert.That(AssemblyLine.SuccessRate(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.SuccessRate(4), Is.EqualTo(1));
        Assert.That(AssemblyLine.SuccessRate(8), Is.EqualTo(0.9));
        Assert.That(AssemblyLine.SuccessRate(9), Is.EqualTo(0.8));
        Assert.That(AssemblyLine.SuccessRate(10), Is.EqualTo(0.77));
        Assert.That(AssemblyLine.SuccessRate(11), Is.EqualTo(0));
    }

    [Test]
    public void ProductionRatePerHourTest()
    {
        Assert.That(AssemblyLine.ProductionRatePerHour(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.ProductionRatePerHour(1), Is.EqualTo(221));
        Assert.That(AssemblyLine.ProductionRatePerHour(10), Is.EqualTo(1701.7));
    }

    [Test]
    public void WorkingItemsPerMinuteTest()
    {
        Assert.That(AssemblyLine.WorkingItemsPerMinute(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.WorkingItemsPerMinute(5), Is.EqualTo(16));
    }
}
