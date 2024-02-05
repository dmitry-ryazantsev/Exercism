namespace ProteinTranslation;

[TestFixture]
public class ProteinTranslationTests
{
    [Test]
    public void Proteins_TranslateRnaStrandIntoCorrectProteinList()
    {
        var proteins = new[] { "Methionine", "Phenylalanine", "Tryptophan" };
        Assert.That(ProteinTranslation.Proteins("AUGUUUUGG"), Is.EqualTo(proteins));
    }

    [Test]
    public void Proteins_TranslationStopsIfStopCodonIsInTheMiddleOfCodonSequence()
    {
        var proteins = new[] { "Tryptophan", "Cysteine", "Tyrosine" };
        Assert.That(ProteinTranslation.Proteins("UGGUGUUAUUAAUGGUUU"), Is.EqualTo(proteins));
    }
}