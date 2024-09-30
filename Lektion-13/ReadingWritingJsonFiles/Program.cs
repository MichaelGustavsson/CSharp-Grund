using System.Text.Encodings.Web;
using System.Text.Json;

namespace ReadingWritingJsonFiles;

class Program
{
    static void Main()
    {
        var erik = new Person()
        {
            Age = 25,
            CreatedAt = DateTime.Now,
            Email = "erik@gmail.com",
            FirstName = "Erik",
            LastName = "Larsson",
            Phone = "031-111222"
        };

        erik.Address = new Address()
        {
            AddressLine = "Citronfjärilsvägen 1",
            PostalCode = "333 44",
            City = "Hålan"
        };

        Console.WriteLine(erik);

        // Spara erik som json, med hjälp av System.Text????...
        // Instruktioner till JsonSerializer för hur vi vill formattera
        // Json utifrån objektet erik...
        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        var path = string.Concat(Environment.CurrentDirectory, "/data/person.json");
        // Omvandla objektet erik till en json sträng...
        var json = JsonSerializer.Serialize(erik, options);
        Console.WriteLine("Skriver till fil...");
        Console.WriteLine(json);
        // Skriv ner json datat till filen person.json...
        File.WriteAllText(path, json);

        // Hämta in filen person.json och läs in all text i variabeln saveJson...
        var savedJson = File.ReadAllText(path);
        Console.WriteLine("Läser ifrån fil...");
        Console.WriteLine(savedJson);

        // Vi måste omvandla json till objekt.
        // Vi måste se till att serialisern skiter i stora eller små bokstäver...
        options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var person = JsonSerializer.Deserialize<Person>(savedJson, options);
        Console.WriteLine("Erik är tillbaka...");
        Console.WriteLine(person);
        Console.WriteLine(person!.Address.AddressLine);
    }
}
