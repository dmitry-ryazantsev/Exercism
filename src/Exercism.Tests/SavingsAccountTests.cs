[TestFixture]
public class SavingsAccountTests
{
    [Test]
    public void InterestRate_NegativeBalance()
    {
        Assert.That(SavingsAccount.InterestRate(-300.0m), Is.EqualTo(3.213f));
    }

    [Test]
    public void InterestRate_FirstTier()
    {
        Assert.That(SavingsAccount.InterestRate(400.0m), Is.EqualTo(0.5f));
    }

    [Test]
    public void InterestRate_SecondTier()
    {
        Assert.That(SavingsAccount.InterestRate(1000.0m), Is.EqualTo(1.621f));
    }

    [Test]
    public void InterestRate_ThirdTier()
    {
        Assert.That(SavingsAccount.InterestRate(5001.0m), Is.EqualTo(2.475f));
    }

    [Test]
    public void Interest_NegativeBalance()
    {
        Assert.That(SavingsAccount.Interest(-10000.0m), Is.EqualTo(-321.3m));
    }

    [Test]
    public void Interest_PositiveBalance()
    {
        Assert.That(SavingsAccount.Interest(4999.99m), Is.EqualTo(81.0498379m));
    }

    [Test]
    public void AnnualBalanceUpdate_PositiveBalance()
    {
        Assert.That(SavingsAccount.AnnualBalanceUpdate(1000.0m), Is.EqualTo(1016.210000m));
    }

    [Test]
    public void AnnualBalanceUpdate_NegativeBalance()
    {
        Assert.That(SavingsAccount.AnnualBalanceUpdate(-0.123m), Is.EqualTo(-0.12695199m));
    }

    [Test]
    public void YearsBeforeDesiredBalance_DifferentStartAndTargetBalance()
    {
        Assert.That(SavingsAccount.YearsBeforeDesiredBalance(2345.67m, 12345.6789m), Is.EqualTo(85));
    }
}