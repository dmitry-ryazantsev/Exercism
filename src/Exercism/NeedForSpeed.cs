namespace NeedForSpeed;

public class RemoteControlCar
{
    private int _speed;
    private int _batteryCharge = 100;
    private int _batteryDrain;
    private int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryCharge < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (_batteryCharge >= _batteryDrain)
        {
            _distanceDriven += _speed;
            _batteryCharge -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

public class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() != _distance)
        {
            if (car.BatteryDrained())
                return false;

            car.Drive();
        }

        return true;
    }
}
