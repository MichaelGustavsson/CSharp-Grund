namespace decisions;

class Program
{
    static void Main()
    {
        int x = 7;

        // if statements...
        // if bygger på logiska operatorer
        // == > < >= =< !
        if (x == 1)
        {
            Console.WriteLine("X = 1");
        }
        else if (x == 3)
        {
            Console.WriteLine("Nu är X = 3");
        }
        else if (x == 7)
        {
            Console.WriteLine("Nu är X = 7");
        }
        else if (x == 10)
        {
            Console.WriteLine("Nu blev det rätt X = 10");
        }
        else
        {
            Console.WriteLine("Då gör vi något annat!");
        }

        // switch statements...
        // Bygger på ett fast värde...
        switch (x)
        {
            case 1:
                Console.WriteLine("Switch här är x = 1");
                break;
            case 3:
                Console.WriteLine("Switch här är x = 1");
                break;
            case 7:
                Console.WriteLine("Switch här är x = 7");
                break;
            case 10:
                Console.WriteLine("Switch här är x = 10");
                break;
            default:
                Console.WriteLine("Switch då gör vi något annat!");
                break;
        }
    }
}
