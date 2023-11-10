namespace HeaterAndWindows;

public class Heater : ICalculateTemperature
{
    public int CalculateTemperature(int outDoorTemperature)
    {
        return outDoorTemperature + 4;
    }
}