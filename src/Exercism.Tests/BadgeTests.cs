[TestFixture]
public class BadgeTests
{
    [Test]
    public void Print_NoId_WhenIdIsNull()
    {
        string expectedOutput = "Bogdan Rosario - MARKETING";
        string actualOutput = Badge.Print(null, "Bogdan Rosario", "Marketing");
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Print_OwnerDepartment_WhenDepartmentIsNull()
    {
        string expectedOutput = "[59] - Julie Sokato - OWNER";
        string actualOutput = Badge.Print(59, "Julie Sokato", null);
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Print_OwnerDepartmentAndNoID_WhenDepartmentAndIdAreNull()
    {
        string expectedOutput = "Amare Osei - OWNER";
        string actualOutput = Badge.Print(null, "Amare Osei", null);
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Print_IdNameAndDepartment_WhenAllAreNotNull()
    {
        string expectedOutput = "[17] - Ryder Herbert - MARKETING";
        string actualOutput = Badge.Print(17, "Ryder Herbert", "Marketing");
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }
}