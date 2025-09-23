class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _distanceDriven;
    private int _batteryLevel;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _batteryLevel = 100;
        _distanceDriven = 0;
    }

    public bool BatteryDrained() => _batteryLevel < _batteryDrain;

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }

        _distanceDriven += _speed;
        _batteryLevel -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            car.Drive();
        } while (!car.BatteryDrained());

        return _distance <= car.DistanceDriven();
    }
}