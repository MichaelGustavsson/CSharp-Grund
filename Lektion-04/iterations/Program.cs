namespace iterations;

class Program
{
    static void Main()
    {
        // WHILE LOOP...
        int i = 1;
        int y = 1;

        while (i <= 5)
        {
            Console.WriteLine("Iteration {0}", i);
            // JÄTTEVIKTIGT! GLÖM INTE ATT RÄKNA UPP VARIABELN!!!
            // i = i + 1;
            i++;
        }

        // DO WHILE LOOP...
        // Körs alltid minst en gång!
        do
        {
            Console.WriteLine("Y har värdet: {0}", y);
            // JÄTTEVIKTIGT! GLÖM INTE ATT RÄKNA UPP VARIABELN!!!
            y++;
        } while (y <= 5);

        // FOR LOOP...
        // Första argumentet = variabeln för räknaren
        // Andra argumentet = Kontroll om loopen ska fortsätta
        // Tredje argument = Räkna upp variabeln
        for (var x = 0; x < 10; x++)
        {
            Console.WriteLine("for loop iteration: {0}", x);
        }

        // FOREACH LOOP...
        // Används för listor som har en inbyggd räknare...
        List<string> names = ["Michael", "Annika", "Malin", "Emma"];

        foreach (var name in names)
        {
            Console.WriteLine("Namnet är {0}", name);
        }


        // EXTRA
        string[] vehicles = ["Volvo", "Ford", "KIA", "Fiat"];

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Fordon: {0}", vehicle);
        }

        for (var z = 0; z < vehicles.Length; z++)
        {
            Console.WriteLine("Bil {0}", vehicles[z]);
        }
    }
}
