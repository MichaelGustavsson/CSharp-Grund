namespace BankApp;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        // Kolla kontot...
        Console.WriteLine("Efter att objektet 'account' är skapat: {0}", account.ToString());

        // Ange kontonummer...
        account.AccountNumber = "33567-4509";
        // Sätt in pengar på kontot...
        account.Deposit(500);

        // Kolla kontot...
        Console.WriteLine("Efter insättning: {0}", account.ToString());

        // Gör ett uttag som överstiger tillgängligt saldo...
        try
        {
            account.WithDraw(600);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // Kolla kontot...
        Console.WriteLine("Efter uttag: {0}", account.ToString());
    }
}
