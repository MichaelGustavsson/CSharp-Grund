namespace BankApp;

class Program
{
    static void Main()
    {
        // Låt oss skapa ett objekt genom att anropa new på BankAccount()
        // Detta skapar ett nytt objekt genom att anropa standard konstruktorn.
        BankAccount account = new BankAccount();

        // Låt oss nu skapa ett nytt objekt av klassen BankAccount
        // men nu gör vi det genom att anropa den överlagrade konstruktor
        // som tar som argument ett kontonummer...
        BankAccount savingsAccount = new BankAccount("8897-56789");

        // Kolla kontot...
        Console.WriteLine("Efter att objektet 'account' är skapat: {0}", account.ToString());
        // Kolla vårt savingsAccount...
        Console.WriteLine("Efter att objektet 'savingsAccount' är skapat: {0}", savingsAccount.ToString());

        // Ange kontonummer...
        account.AccountNumber = "33567-4509";

        // Sätt in pengar på kontot...
        account.Deposit(500);
        // Sätt in pengar på vårt sparkonto(savingsAccount)...
        savingsAccount.Deposit(2500);

        // Kolla kontot...
        Console.WriteLine("Efter insättning: {0}", account.ToString());
        // Kolla vårt savingsAccount...
        Console.WriteLine("Efter insättning: {0}", savingsAccount.ToString());

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
        Console.WriteLine("Saldo efter uttag: {0}", account.ToString());

        // Gör ett uttag ifrån vårt sparkonto(savingsAccount)
        try
        {
            savingsAccount.WithDraw(1200);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Kolla sparkontot...
        Console.WriteLine("Saldo efter uttag: {0}", savingsAccount.ToString());
    }
}
