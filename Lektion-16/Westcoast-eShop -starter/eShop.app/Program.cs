using eShop.models;

namespace eShop.app;

class Program
{
    static void Main()
    {
        var path = string.Concat(Environment.CurrentDirectory, "/Data/orders.json");
        var orders = Storage.ReadJson(path);

        foreach (var order in orders)
        {
            Console.WriteLine(order);

            foreach (var item in order!.OrderItems!)
            {
                Console.WriteLine(item);
            }
        }
    }
}
