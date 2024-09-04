using System.Collections;
using System.Linq.Expressions;

namespace lists;

class Program
{
    static void Main()
    {
        // Dynamisk otypad lista...
        // ArrayList vehicles = new ArrayList();

        // Generic typad lista...
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Vehicle());
        // vehicles.Add(new BankAccount());

        foreach (Vehicle car in vehicles)
        {
            Console.WriteLine(car);
        }

        // ArrayList vehicles = new();
        // ArrayList vehicles = [];
    }
}

public class Vehicle { }
public class BankAccount { }
