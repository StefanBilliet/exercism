class RemoteControlCar
{
    private int _metersDriven = 0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        var batteryPercentage = 100f -_metersDriven / 2000f * 100;
        return batteryPercentage== 0 ? "Battery empty" : $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if (_metersDriven >= 2000)
        {
            return;
        }
        
        _metersDriven += 20;
    }
}
