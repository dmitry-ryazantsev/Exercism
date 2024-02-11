namespace ResistorColorDuo;

[TestFixture]
public class ResistorColorDuoTests
{
    [Test]
    public void Value_IgnoredAdditionalColors()
    {
        Assert.That(ResistorColorDuo.Value(new[] { "green", "brown", "orange" }), Is.EqualTo(51));
    }

    [Test]
    public void Value_BlackAndBrownReturnsOneDigit()
    {
        Assert.That(ResistorColorDuo.Value(new[] { "black", "brown" }), Is.EqualTo(1));
    }

    [Test]
    public void Value_PinkIsNotFound()
    {
        Assert.That(ResistorColorDuo.Value(new[] { "pink" }), Is.EqualTo(-1));
    }
}