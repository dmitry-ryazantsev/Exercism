[TestFixture]
public class AssemblyLineTests
{
    [Test]
    public void SuccessRate_ReturnsExpectedValues()
    {
        Assert.That(AssemblyLine.SuccessRate(-2), Is.EqualTo(0));
        Assert.That(AssemblyLine.SuccessRate(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.SuccessRate(4), Is.EqualTo(1));
        Assert.That(AssemblyLine.SuccessRate(8), Is.EqualTo(0.9));
        Assert.That(AssemblyLine.SuccessRate(9), Is.EqualTo(0.8));
        Assert.That(AssemblyLine.SuccessRate(10), Is.EqualTo(0.77));
        Assert.That(AssemblyLine.SuccessRate(11), Is.EqualTo(0));
    }

    [Test]
    public void ProductionRatePerHour_ReturnsExpectedValues()
    {
        Assert.That(AssemblyLine.ProductionRatePerHour(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.ProductionRatePerHour(1), Is.EqualTo(221));
        Assert.That(AssemblyLine.ProductionRatePerHour(10), Is.EqualTo(1701.7));
        Assert.That(AssemblyLine.ProductionRatePerHour(11), Is.EqualTo(0));
    }

    [Test]
    public void WorkingItemsPerMinute_ReturnsExpectedValues()
    {
        Assert.That(AssemblyLine.WorkingItemsPerMinute(0), Is.EqualTo(0));
        Assert.That(AssemblyLine.WorkingItemsPerMinute(5), Is.EqualTo(16));
        Assert.That(AssemblyLine.WorkingItemsPerMinute(11), Is.EqualTo(0));
    }
}
