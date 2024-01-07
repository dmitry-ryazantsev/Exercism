[TestFixture]
public class RollTheDieTests
{
    [Test]
    public void RollDie_InRangeOf1To18()
    {
        Player player = new Player();
        for (int i = 0; i < 1000; i++)
        {
            Assert.That(player.RollDie(), Is.InRange(1, 18));
        }
    }

    [Test]
    public void GenerateSpellStrength_InRangeOf0To100()
    {
        Player player = new Player();
        for (int i = 0; i < 1000; i++)
        {
            Assert.That(player.GenerateSpellStrength(), Is.InRange(0.0, 100.0));
        }
    }
}