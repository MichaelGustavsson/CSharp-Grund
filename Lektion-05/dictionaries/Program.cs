namespace dictionaries;

class Program
{
    static void Main()
    {
        Dictionary<string, string> vehiclesInfo = new Dictionary<string, string>();

        vehiclesInfo.Add("ABC123", "Volvo XC60");
        vehiclesInfo.Add("DEF456", "Ford Mustang MACH-E");
        vehiclesInfo.Add("FGH789", "KIA EV6");

        var vehicle = vehiclesInfo["FGH789"];

        Console.WriteLine(vehicle);

        foreach (KeyValuePair<string, string> car in vehiclesInfo)
        {
            Console.WriteLine("RegNo: {0}, Model: {1}", car.Key, car.Value);
        }
    }
}
