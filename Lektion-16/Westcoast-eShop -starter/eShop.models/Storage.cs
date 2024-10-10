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
    var json = JsonSerializer.Serialize(orders, _options);
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
}