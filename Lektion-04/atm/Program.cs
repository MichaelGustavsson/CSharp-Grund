namespace atm;

class Program
{
    static void Main()
    {
        try
        {
            // Skapar ett objekt ifrån klassen
            // BankAccount...
            // Skapar en kopia av varibler och metoder
            // som finns i klassen BankAccount och 
            // placerar kopian i variabeln myAccount.
            BankAccount myAccount = new BankAccount();

            // Hämta aktuellt saldo ifrån objektet
            // myAccount och placera dess värde i
            // variabeln "myBalance"
            int myBalance = myAccount.DisplayBalance();
            Console.WriteLine("Aktuellt saldo {0}", myBalance);

            // Sätt in pengar på kontot...
            Console.WriteLine("Ange hur mycket du vill sätta in.");
            int amount = int.Parse(Console.ReadLine()!);
            myAccount.Deposit(amount);
            // Kontrollera saldot...
            myBalance = myAccount.DisplayBalance();
            Console.WriteLine("Aktuellt saldo {0}", myBalance);

            // Ta pengar ifrån kontot...
            Console.WriteLine("Hur mycket vill du ta ut?");
            amount = int.Parse(Console.ReadLine()!);
            myAccount.WithDraw(amount);

            // Kontrollera saldot...
            myBalance = myAccount.DisplayBalance();
            Console.WriteLine("Aktuellt saldo {0}", myBalance);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Det gick inte så bra. {0}", ex.Message);
        }
    }
}

