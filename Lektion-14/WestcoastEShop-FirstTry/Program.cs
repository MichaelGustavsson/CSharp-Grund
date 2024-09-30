using System.Text.Encodings.Web;
using System.Text.Json;
using Westcoast_EShop.Models;

namespace Westcoast_EShop;

public class Program
{
  static void Main()
  {
    // Uppgift:
    // Skapa ett SalesOrder objekt
    // Skriv ut det i json format i en salesorder.json fil
    // som ska ligga i en katalog Data...

    // 1.   Skapa katalogen Data...
    // 1.1  Manuellt arbete i "Explorer" fönstret...✅

    // 2.   Skapa ett objekt av typen SalesOrder...✅
    var order = new SalesOrder();

    // 3.   Ange värden på egenskaperna i objektet...✅
    order.OrderDate = DateTime.Now;
    order.OrderId = 1;
    order.Customer = new Customer
    {
      CustomerId = 100,
      CreatedAt = DateTime.Now,
      LastBuy = DateTime.Now,
      FirstName = "Anneli",
      LastName = "Oskarsson",
      AddressLine = "Storgatan 8",
      PostalCode = "123 45",
      City = "Storstaden"
    };

    // 4.   Gör om objektet till Json...
    //      ska vara camelCase och se upp med åäö!!!✅
    var options = new JsonSerializerOptions
    {
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
      WriteIndented = true
    };
    var json = JsonSerializer.Serialize(order, options);

    // 5.   Skriv ner Json till katalogen Data...
    // 5.1  Ta reda på applikationens placering.
    // 5.2  Skriv till disk...
    var path = string.Concat(Environment.CurrentDirectory, "/Data/order.json");
    File.WriteAllText(path, json);
  }
}