namespace stacks;

public class Program
{
    static void Main()
    {
        // LIFO = Last In First Out...
        Stack<string> vehicles = new Stack<string>();
        vehicles.Push("Volvo");
        vehicles.Push("Ford");
        vehicles.Push("Fiat");
        vehicles.Push("KIA");
        vehicles.Push("Zeekr");

        // while (vehicles.Count > 0)
        // {
        //     Console.WriteLine("Tillverkare: {0}", vehicles.Pop());
        // }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Tillverkare: {0}", vehicle);
        }
    }
}
