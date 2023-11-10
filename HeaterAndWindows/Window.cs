namespace HeaterAndWindows;

public class Window : ICalculateTemperature
{
    public int CalculateTemperature(int outDoorTemperature)
    {
        return outDoorTemperature -1;
    }
}