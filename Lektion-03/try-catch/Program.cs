namespace simpleArrays;

class Program
{
    static void Main()
    {
        try
        {
            // Kasta fel(undantag/exceptions)...
            throw new Exception("Nu gick du bananas");

            // ARRAY METOD 1...
            int[] numbers = new int[5];

            // Lägg till ett heltal med hjälp av
            // listans index(position)...
            // Lägg in värdet 1 på första positionen(0)...
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            // Kommer inte att fungera, finns ej plats för
            // en 6:e byrålåda...
            // numbers[5] = 6;

            Console.WriteLine("Värdet i listan: " + numbers[4]);

            // ARRAY METOD 2...
            // Skapar och fyller på listan med färdiga värden...
            int[] values = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            Console.WriteLine("Aktuellt värde i listan values: " + values[5]);

            // ARRAY MED STRÄNGAR...
            // string[] vehicles = new string[5];
            string[] vehicles = ["Volvo", "Ford", "KIA"];

            // ARRAY MED OBJEKT...
            object[] queries = [
                new { query = "Fråga 1", answer = "Svar på fråga 1" },
            new { query = "Fråga 2", answer = "Svar på fråga 2" },
            new { query = "Fråga 3", answer = "Svar på fråga 3" }];

            // ARRAY METODER...
            Console.WriteLine("Antal element i vehicles: " + vehicles.Length);
            Console.WriteLine("Första bilen i vehicles: " + vehicles.First());
            Console.WriteLine("Sista bilen i vehicles: " + vehicles.Last());
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hoppsan det gick lite fel! {0}", ex.Message);
        }
        finally
        {
            // Finally används för att städa upp resurser som inte används längre...
            Console.WriteLine("Nu är vi färdiga!!!");
        }
    }
}
