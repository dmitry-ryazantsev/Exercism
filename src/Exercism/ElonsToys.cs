namespace ElonsToys;

public class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _batteryCharge = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => _batteryCharge > 0 ? $"Battery at {_batteryCharge}%" : $"Battery empty";

    public void Drive()
    {
        if (_batteryCharge > 0)
        {
            _distanceDriven += 20;
            _batteryCharge--;
        }
    }
}
