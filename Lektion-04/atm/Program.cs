using System.Transactions;

namespace atm;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("För att avsluta programmet tryck på x");
        Console.WriteLine("För att se saldo tryck på b");
        Console.WriteLine("För att sätta in pengar tryck på d");
        Console.WriteLine("För att ta ut pengar tryck på w");
        Console.WriteLine("För att se aktuella transaktioner tryck på t");
        Console.WriteLine("------------------------------------------------");

        int balance;
        BankAccount account = new BankAccount();

        while (true)
        {
            // Skapar en sträng som kan vara null(inte innehålla något).
            string? key = Console.ReadLine();

            if (key == "x")
            {
                Environment.Exit(0);
            }
            else if (key == "b")
            {
                balance = account.DisplayBalance();
                Console.WriteLine("Aktuellt saldo {0}", balance);
            }
            else if (key == "d")
            {
                Console.WriteLine("Hur mycket vill du sätta in?");
                int amount = int.Parse(Console.ReadLine()!);
                account.Deposit(amount);
            }
            else if (key == "w")
            {
                try
                {
                    Console.WriteLine("Hur mycket vill du ta ut?");
                    int amount = int.Parse(Console.ReadLine()!);
                    account.WithDraw(amount);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (key == "t")
            {
                var transactions = account.DisplayTransactions();

                foreach (var transaction in transactions)
                {
                    Console.WriteLine("Transaktionsvärde: {0}", transaction);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

