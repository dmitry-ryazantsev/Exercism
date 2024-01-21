namespace ReverseString;

[TestFixture]
public class ReverseStringTests
{
    [Test]
    public void Reverse_AnEmptyString()
    {
        Assert.That(ReverseString.Reverse(""), Is.EqualTo(""));
    }

    [Test]
    public void Reverse_AWord()
    {
        Assert.That(ReverseString.Reverse("stressed"), Is.EqualTo("desserts"));
    }

    [Test]
    public void Reverse_ACapitalisedWord()
    {
        Assert.That(ReverseString.Reverse("PeAr"), Is.EqualTo("rAeP"));
    }

    [Test]
    public void Reverse_APalindrom()
    {
        Assert.That(ReverseString.Reverse("racecar"), Is.EqualTo("racecar"));
    }
}