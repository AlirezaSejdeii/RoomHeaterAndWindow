using HeaterAndWindows;

foreach (KeyValuePair<TimeOnly, int> item in Data.TimeAndOutDoorTemperature)
{
    Room room = Room.Create(item.Value, item.Key);
    Console.WriteLine(room.Status);
}