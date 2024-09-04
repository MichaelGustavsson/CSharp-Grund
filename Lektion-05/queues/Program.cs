namespace queues;

class Program
{
    static void Main()
    {
        Queue<string> vehicles = new Queue<string>();
        vehicles.Enqueue("Volvo");
        vehicles.Enqueue("Ford");
        vehicles.Enqueue("KIA");
        vehicles.Enqueue("Fiat");
        vehicles.Enqueue("Zeekr");

        // while (vehicles.Count > 0)
        // {
        //     Console.WriteLine("Tillverkare: {0}", vehicles.Dequeue());
        // }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Tillverkare: {0}", vehicle);
        }
    }
}
