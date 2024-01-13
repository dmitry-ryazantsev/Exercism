namespace NeedForSpeed;

[TestFixture]
public class RemoteControlCarTests
{
    [Test]
    public void TryFinishTrack_WithCarThatCanEasilyFinish()
    {
        int speed = 10;
        int batteryDrain = 2;
        int distance = 100;

        RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);
        RaceTrack track = new RaceTrack(distance);

        Assert.That(track.TryFinishTrack(car), Is.True);
    }

    [Test]
    public void TryFinishTrack_WithCarThatCanBarelyFinish()
    {
        int speed = 2;
        int batteryDrain = 10;
        int distance = 20;

        RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);
        RaceTrack track = new RaceTrack(distance);

        Assert.That(track.TryFinishTrack(car), Is.True);
    }

    [Test]
    public void TryFinishTrack_WithCarThatCannotFinish()
    {
        int speed = 1;
        int batteryDrain = 20;
        int distance = 678;

        RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);
        RaceTrack track = new RaceTrack(distance);

        Assert.That(track.TryFinishTrack(car), Is.False);
    }
}