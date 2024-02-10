namespace ResistorColor;

[TestFixture]
public class ResistorColorTests
{
    [Test]
    public void ColorCode_OrangeIsFoundWhenInLowerCase()
    {
        Assert.That(ResistorColor.ColorCode("orange"), Is.EqualTo(3));
    }

    [Test]
    public void ColorCode_GreenIsFoundWhenInUpperCase()
    {
        Assert.That(ResistorColor.ColorCode("GREEN"), Is.EqualTo(5));
    }

    [Test]
    public void ColorCode_PinkIsNotFound()
    {
        Assert.That(ResistorColor.ColorCode("pink"), Is.EqualTo(-1));
    }
}