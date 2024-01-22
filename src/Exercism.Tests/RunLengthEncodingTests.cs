namespace RunLengthEncoding;

[TestFixture]
public class RunLengthEncodingTests
{
    [Test]
    public void Encode_AnEmptyString()
    {
        Assert.That(RunLengthEncoding.Encode(""), Is.EqualTo(""));
    }

    [Test]
    public void Encode_ALongString()
    {
        Assert.That(RunLengthEncoding.Encode("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"), Is.EqualTo("12WB12W3B24WB"));
    }

    [Test]
    public void Encode_AStringWithSingleCharacters()
    {
        Assert.That(RunLengthEncoding.Encode("XYZ"), Is.EqualTo("XYZ"));
    }

    [Test]
    public void Encode_AStringInLowerCase()
    {
        Assert.That(RunLengthEncoding.Encode("aabbbcccc"), Is.EqualTo("2a3b4c"));
    }

    [Test]
    public void Decode_AnEmptyString()
    {
        Assert.That(RunLengthEncoding.Decode(""), Is.EqualTo(""));
    }

    [Test]
    public void Decode_ALongString()
    {
        Assert.That(RunLengthEncoding.Decode("12WB12W3B24WB"), Is.EqualTo("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"));
    }

    [Test]
    public void Decode_AStringWithSingleCharacters()
    {
        Assert.That(RunLengthEncoding.Decode("XYZ"), Is.EqualTo("XYZ"));
    }
}