namespace introCSharp;

class Program
{
    static void Main()
    {
        // One liner...
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Det funkar ju!!!");
        // Console.WriteLine(b);
        /* Radbruten kommentar
            Här kommer min berättelse
         */
        // var test;
        // var firstName = Console.ReadLine();
        // var name = SayHello();
        // var greeting = SayHello("Välkommen");
        // var message = SayHello("Du är bäst", name);

        // Console.WriteLine("Hej " + name);
        // Console.WriteLine(greeting);
        // Console.WriteLine(message);

        // var value1 = Console.ReadLine();
        // var value2 = Console.ReadLine();
        // Console.WriteLine(value1 + value2);
        // Deklarering av variabler...

        // int x;
        // int y;
        // Initiering(tilldelning) av värde...
        // x = 10;
        // y = 20 + x--;
        // Deklaration och initiering av variabler...
        // var z = 10;
        // Console.WriteLine(x + y);

        // double i = 10.57;
        // int x = (int)i;

        // string z = i.ToString();
        // string a = x.ToString();
        // string c = "12345";
        // int b = Convert.ToInt32(c);
        // int b = int.Parse(c);

        // Console.WriteLine(x);
        // Console.WriteLine(z);
        // Console.WriteLine(b);

        Console.WriteLine("Hur mycket vill du sätta in?");
        var deposit = Console.ReadLine();
        Console.WriteLine("Du har så här mycket på ditt konto: " + deposit);
        Console.WriteLine("Hur mycket vill du ta ut?");
        var amount = Console.ReadLine();

    }

    // static string SayHello()
    // {
    //     var name = Console.ReadLine();
    //     return name;
    // }

    // static string SayHello(string message)
    // {
    //     var name = Console.ReadLine();
    //     return message + " " + name;
    // }

    // static string SayHello(string message, string name)
    // {
    //     return message + " " + name;
    // }
}
