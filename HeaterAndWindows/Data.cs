namespace HeaterAndWindows;

public class Data
{
   public static Dictionary<TimeOnly, int> TimeAndOutDoorTemperature = new()
    {
        { TimeOnly.Parse("05:00:00"), 25 },
        { TimeOnly.Parse("06:00:00"), 26 },
        { TimeOnly.Parse("07:00:00"), 26 },
        { TimeOnly.Parse("08:00:00"), 27 },
        { TimeOnly.Parse("09:00:00"), 27 },
        { TimeOnly.Parse("10:00:00"), 30 },
        { TimeOnly.Parse("11:00:00"), 30 },
        { TimeOnly.Parse("12:00:00"), 30 },
        { TimeOnly.Parse("13:00:00"), 33 },
        { TimeOnly.Parse("14:00:00"), 33 },
        { TimeOnly.Parse("15:00:00"), 33 },
        { TimeOnly.Parse("16:00:00"), 33 },
        { TimeOnly.Parse("17:00:00"), 32 },
        { TimeOnly.Parse("18:00:00"), 32 },
        { TimeOnly.Parse("19:00:00"), 32 }
    };
}