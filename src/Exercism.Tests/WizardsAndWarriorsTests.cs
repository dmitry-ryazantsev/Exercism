namespace WizardsAndWarriors;

[TestFixture]
public class WizardsAndWarriorsTests
{
    [Test]
    public void ToString_DescribeWizard()
    {
        Wizard wizard = new Wizard();
        Assert.That(wizard.ToString(), Is.EqualTo("Character is a Wizard"));
    }

    [Test]
    public void ToString_DescribeWarrior()
    {
        Warrior warrior = new Warrior();
        Assert.That(warrior.ToString(), Is.EqualTo("Character is a Warrior"));
    }

    [Test]
    public void DamagePoints_WizardWithPreparedSpell()
    {
        Warrior warrior = new Warrior();
        Wizard wizard = new Wizard();
        wizard.PrepareSpell();

        Assert.That(wizard.DamagePoints(warrior), Is.EqualTo(12));
    }

    [Test]
    public void DamagePoints_WizardWithoutPreparedSpell()
    {
        Wizard wizard = new Wizard();
        Wizard otherWizard = new Wizard();

        Assert.That(wizard.DamagePoints(otherWizard), Is.EqualTo(3));
    }

    [Test]
    public void DamagePoints_WarriorAttackingVulnerableTarget()
    {
        Warrior warrior = new Warrior();
        Wizard wizard = new Wizard();

        Assert.That(warrior.DamagePoints(wizard), Is.EqualTo(10));
    }

    [Test]
    public void DamagePoints_WarriorAttackingNonVulnerableTarget()
    {
        Warrior warrior = new Warrior();
        Wizard wizard = new Wizard();
        wizard.PrepareSpell();

        Assert.That(warrior.DamagePoints(wizard), Is.EqualTo(6));
    }
}