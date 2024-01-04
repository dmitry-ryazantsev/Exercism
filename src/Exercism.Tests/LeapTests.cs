[TestFixture]
public class LeapTests
{
    [Test]
    public void IsLeapYear_YearNotDivisibleByFour()
    {
        Assert.False(Leap.IsLeapYear(2015));
    }

    [Test]
    public void IsLeapYear_YearDivisibleByFour_NotDivisibleByHundred()
    {
        Assert.True(Leap.IsLeapYear(1996));
    }

    [Test]
    public void IsLeapYear_YearDivisibleByHundred_NotDivisibleByFourHundred()
    {
        Assert.False(Leap.IsLeapYear(2100));
    }

    [Test]
    public void IsLeapYear_YearDivisibleByFourHundred()
    {
        Assert.True(Leap.IsLeapYear(2000));
    }
}