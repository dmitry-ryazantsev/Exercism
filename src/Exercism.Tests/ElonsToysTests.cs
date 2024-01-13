namespace ElonsToys;

[TestFixture]
public class RemoteControlCarTests
{
    [Test]
    public void Buy_ReturnsAnObject()
    {
        RemoteControlCar car = RemoteControlCar.Buy();
        Assert.NotNull(car);
    }

    [Test]
    public void DistanceDisplay_ZeroMetersForANewCar()
    {
        RemoteControlCar car = new RemoteControlCar();
        var distanceDriven = 0;

        Assert.That(car.DistanceDisplay(), Is.EqualTo($"Driven {distanceDriven} meters"));
    }

    [Test]
    public void BatteryDisplay_HundredPercentForANewCar()
    {
        RemoteControlCar car = new RemoteControlCar();
        var batteryCharge = 100;

        Assert.That(car.BatteryDisplay(), Is.EqualTo($"Battery at {batteryCharge}%"));
    }

    [Test]
    public void DistanceDisplay_AfterDrivingOnce()
    {
        RemoteControlCar car = new RemoteControlCar();
        var singleDrive = 20;

        car.Drive();

        Assert.That(car.DistanceDisplay(), Is.EqualTo($"Driven {singleDrive} meters"));
    }

    [Test]
    public void DistanceDisplay_AfterDrivingMultipleTimes()
    {
        RemoteControlCar car = new RemoteControlCar();
        var distanceDriven = 0;

        for (var i = 0; i < 17; i++)
        {
            car.Drive();
            distanceDriven += 20;
        }

        Assert.That(car.DistanceDisplay(), Is.EqualTo($"Driven {distanceDriven} meters"));
    }

    [Test]
    public void BatteryDisplay_AfterDrivingOnce()
    {
        RemoteControlCar car = new RemoteControlCar();
        var batteryAfterSingleUse = 99;

        car.Drive();

        Assert.That(car.BatteryDisplay(), Is.EqualTo($"Battery at {batteryAfterSingleUse}%"));
    }

    [Test]
    public void BatteryDisplay_AfterDrivingMultipleTimes()
    {
        RemoteControlCar car = new RemoteControlCar();
        var batteryCharge = 100;

        for (var i = 0; i < 17; i++)
        {
            car.Drive();
            batteryCharge--;
        }

        Assert.That(car.BatteryDisplay(), Is.EqualTo($"Battery at {batteryCharge}%"));
    }

    [Test]
    public void BatteryDisplay_AfterBatteryEmpty()
    {
        RemoteControlCar car = new RemoteControlCar();
        var batteryCharge = 100;

        for (var i = 0; i < 100; i++)
        {
            car.Drive();
            batteryCharge--;
        }

        Assert.That(car.BatteryDisplay(), Is.EqualTo($"Battery empty"));
    }

    [Test]
    public void DistanceDisplay_AfterBatteryEmpty()
    {
        RemoteControlCar car = new RemoteControlCar();
        var distanceDriven = 0;

        for (var i = 0; i < 100; i++)
        {
            car.Drive();
            distanceDriven += 20;
        }

        Assert.That(car.DistanceDisplay(), Is.EqualTo($"Driven {distanceDriven} meters"));
    }
}