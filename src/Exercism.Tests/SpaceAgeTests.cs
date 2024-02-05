namespace SpaceAge;

[TestFixture]
public class SpageAgeTests
{
    [Test]
    public void AgeOnEarth()
    {
        var age = new SpaceAge(1000000000);
        Assert.That(Math.Round(age.OnEarth(), 2), Is.EqualTo(31.69));
    }

    [Test]
    public void AgeOnMercury()
    {
        var age = new SpaceAge(2134835688);
        Assert.That(Math.Round(age.OnMercury(), 2), Is.EqualTo(280.88));
    }

    [Test]
    public void AgeOnVenus()
    {
        var age = new SpaceAge(189839836);
        Assert.That(Math.Round(age.OnVenus(), 2), Is.EqualTo(9.78));
    }
}