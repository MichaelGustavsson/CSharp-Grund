using System.Text.Encodings.Web;
using System.Text.Json;

namespace eShop.models;

public class Storage<T>
{

  private static JsonSerializerOptions _options = new()
  {
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true
  };

  // 1. Skapa en static metod för att spara ner objekt till json...
  public static void WriteJson(string path, List<T> data)
  {
    var options = new JsonSerializerOptions
    {
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
      WriteIndented = true
    };
    var json = JsonSerializer.Serialize(data, options);
    File.WriteAllText(path, json);
  }

  public static List<T> ReadJson(string path)
  {
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };

    var json = File.ReadAllText(path);
    var data = JsonSerializer.Deserialize<List<T>>(json, _options);
    return data!;
  }
}