namespace HeaterAndWindows;

public abstract class CalculateTemperatureFactory
{
    public static ICalculateTemperature GetTemperatureCalculator(int outDoorTemperature)
    {
        if (outDoorTemperature > 30)
        {
            return new Window();
        }

        return new Heater();
    }
}