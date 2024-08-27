namespace stringDemo;

class Program
{
    static void Main()
    {
        string name = "Jensen Education";
        Console.WriteLine(name);

        // string character = name.Substring(5);
        string character = name.Substring(5, 4);
        Console.WriteLine(character);

        string[] words = name.Split(' ');
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        double value = 7988.6795;

        // Slå samman två argument...
        Console.WriteLine("Värdet är: " + value);

        Console.WriteLine("Värdet är: " + value + " " + name);

        // Använda en "template" sträng...
        // {0} är en "placeholder" för första argumentet efter
        // komma tecknet...
        Console.WriteLine("Värdet är: {0} {1}", value, name);

        // Formatterar value = 7988.6795 => 7 988.68
        Console.WriteLine("Värdet är: {0:N2} {1}", value, name);
    }
}
