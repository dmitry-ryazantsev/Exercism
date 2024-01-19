namespace Bob;

[TestFixture]
public class BobTests
{
    [Test]
    public void Response_WhenAQuestionIsAsked()
    {
        Assert.That(Bob.Response("How are you doing?"), Is.EqualTo("Sure."));
    }

    [Test]
    public void Response_WhenAQuestionIsAskedYelling()
    {
        Assert.That(Bob.Response("HOW ARE YOU?"), Is.EqualTo("Calm down, I know what I'm doing!"));
    }

    [Test]
    public void Response_WhenYelledAt()
    {
        Assert.That(Bob.Response("STOP!"), Is.EqualTo("Whoa, chill out!"));
    }

    [Test]
    public void Response_ToSilenceWithWhitespaces()
    {
        Assert.That(Bob.Response("    "), Is.EqualTo("Fine. Be that way!"));
    }

    [Test]
    public void Response_ToSilenceWithAnEmptyString()
    {
        Assert.That(Bob.Response(""), Is.EqualTo("Fine. Be that way!"));
    }

    [Test]
    public void Response_WhenThereIsAGeneralStatement()
    {
        Assert.That(Bob.Response("Ending with ? means a question."), Is.EqualTo("Whatever."));
    }
}