namespace Darts;

[TestFixture]
public class DartsTests
{
    [Test]
    public void Missed_target()
    {
        Assert.That(Darts.Score(-9, 9), Is.EqualTo(0));
    }

    [Test]
    public void On_the_outer_circle()
    {
        Assert.That(Darts.Score(0, 10), Is.EqualTo(1));
    }

    [Test]
    public void On_the_middle_circle()
    {
        Assert.That(Darts.Score(-5, 0), Is.EqualTo(5));
    }

    [Test]
    public void On_the_inner_circle()
    {
        Assert.That(Darts.Score(0, -1), Is.EqualTo(10));
    }

    [Test]
    public void Exactly_on_centre()
    {
        Assert.That(Darts.Score(0, 0), Is.EqualTo(10));
    }

    [Test]
    public void Near_the_centre()
    {
        Assert.That(Darts.Score(-0.1, -0.1), Is.EqualTo(10));
    }

    [Test]
    public void Just_within_the_inner_circle()
    {
        Assert.That(Darts.Score(0.7, 0.7), Is.EqualTo(10));
    }

    [Test]
    public void Just_outside_the_inner_circle()
    {
        Assert.That(Darts.Score(0.8, -0.8), Is.EqualTo(5));
    }

    [Test]
    public void Just_within_the_middle_circle()
    {
        Assert.That(Darts.Score(-3.5, 3.5), Is.EqualTo(5));
    }

    [Test]
    public void Just_outside_the_middle_circle()
    {
        Assert.That(Darts.Score(-3.6, -3.6), Is.EqualTo(1));
    }

    [Test]
    public void Just_within_the_outer_circle()
    {
        Assert.That(Darts.Score(-7, 7), Is.EqualTo(1));
    }

    [Test]
    public void Just_outside_the_outer_circle()
    {
        Assert.That(Darts.Score(7.1, -7.1), Is.EqualTo(0));
    }
}