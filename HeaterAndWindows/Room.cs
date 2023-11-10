namespace HeaterAndWindows;

public class Room
{
    private readonly int _outDoorTemperature;
    private readonly ICalculateTemperature _temperatureCalculator;

    private Room(ICalculateTemperature temperatureCalculator, TimeOnly timeNow, int outDoorTemperature)
    {
        _outDoorTemperature = outDoorTemperature;
        _temperatureCalculator = temperatureCalculator;
        TimeNow = timeNow;
    }

    public TimeOnly TimeNow { get; }
    public int GetTemperature => _temperatureCalculator.CalculateTemperature(_outDoorTemperature);

    public string Status =>
        $"Time: {TimeNow.Hour} Temperature: {GetTemperature}C Heater: {HeaterStatus} Window: {WindowStatus}";


    private string HeaterStatus => _temperatureCalculator.GetType() == typeof(Heater) ? "On" : "Off";
    private string WindowStatus => _temperatureCalculator.GetType() == typeof(Window) ? "Open" : "Close";

    public static Room Create(int outDoorTemperature, TimeOnly timeNow)
    {
        ICalculateTemperature calculateTemperature =
            CalculateTemperatureFactory.GetTemperatureCalculator(outDoorTemperature);
        return new Room(calculateTemperature, timeNow, outDoorTemperature);
    }
}