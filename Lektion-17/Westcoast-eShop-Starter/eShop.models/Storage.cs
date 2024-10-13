using System.Text.Encodings.Web;
using System.Text.Json;

namespace eShop.models;

public class Storage
{

  private static JsonSerializerOptions _options = new()
  {
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true
  };

  // 1. Skapa en static metod för att spara ner objekt till json...
  public static void WriteJson(string path, List<SalesOrder> orders)
  {
    var options = new JsonSerializerOptions
    {
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
      WriteIndented = true
    };
    var json = JsonSerializer.Serialize(orders, options);
    File.WriteAllText(path, json);
  }

  public static void WriteInvoicesJson(string path, List<Invoice> invoices)
  {
    var options = new JsonSerializerOptions
    {
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
      WriteIndented = true
    };

    var json = JsonSerializer.Serialize(invoices, options);
    File.WriteAllText(path, json);
  }
  public static List<SalesOrder> ReadJson(string path)
  {
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    var json = File.ReadAllText(path);
    var orders = JsonSerializer.Deserialize<List<SalesOrder>>(json, _options);
    return orders!;
  }

  public static List<Product> ReadProductsJson(string path)
  {
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    var json = File.ReadAllText(path);
    var products = JsonSerializer.Deserialize<List<Product>>(json, _options);
    return products!;
  }

  public static List<Customer> ReadCustomersJson(string path)
  {
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    var json = File.ReadAllText(path);
    var customers = JsonSerializer.Deserialize<List<Customer>>(json, _options);
    return customers!;
  }

  public static List<Invoice> ReadInvoicesJson(string path)
  {
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    var json = File.ReadAllText(path);
    var invoices = JsonSerializer.Deserialize<List<Invoice>>(json, _options);
    return invoices!;
  }
}