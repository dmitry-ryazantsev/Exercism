[TestFixture]
public class AssemblyLineTests
{
    // parametrised tests
    [TestCase(-2, 0)]
    [TestCase(4, 1)]
    [TestCase(8, 0.9)]
    [TestCase(9, 0.8)]
    [TestCase(10, 0.77)]
    [TestCase(11, 0)]
    public void SuccessRate_ReturnsExpectedValue(int speed, double successRate)
    {
        Assert.That(AssemblyLine.SuccessRate(speed), Is.EqualTo(successRate));
    }

    [TestCase(0, 0)]
    [TestCase(1, 221)]
    [TestCase(10, 1701.7)]
    [TestCase(11, 0)]
    public void ProductionRatePerHour_ReturnsExpectedValue(int speed, double productionRatePerHour)
    {
        Assert.That(AssemblyLine.ProductionRatePerHour(speed), Is.EqualTo(productionRatePerHour));
    }

    [TestCase(0, 0)]
    [TestCase(5, 16)]
    [TestCase(11, 0)]
    public void WorkingItemsPerMinute_ReturnsExpectedValue(int speed, int workingItemsPerMinute)
    {
        Assert.That(AssemblyLine.WorkingItemsPerMinute(speed), Is.EqualTo(workingItemsPerMinute));
    }
}
