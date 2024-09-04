namespace MyBank;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount();
        myAccount.AccountNumber = "AZ2345667";
        // myAccount.SetAccountNumber("AZ2345667");
        Console.WriteLine("Kontonummer: {0}", myAccount.AccountNumber);
        Console.WriteLine("Kontonummer: {0} skapat: {1}",
            myAccount.AccountNumber, myAccount.CreateAt);

        // Console.WriteLine("Kontonummer: {0}", myAccount.GetAccountNumber());
        // myAccount.Balance = 500;

        // Skapa ett nytt objekt...
        BankAccount mySecondAccount = new BankAccount("XYZ123");
        BankAccount myThirdAccount = new BankAccount("XYZ123", 500);

        // Objekt initiering...
        // BankAccount newAccount = new BankAccount { accountNumber = "CVR456789" };

        myAccount.Deposit(100, 1.025M);
        Console.WriteLine("Mitt konto: {0}", myAccount.ToString());

        try
        {
            myAccount.WithDraw(450);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Mitt konto: {0}", myAccount.ToString());

        decimal balance = myAccount.Balance;
        Console.WriteLine("Mitt aktuella saldo: {0}", balance);

        myAccount.Deposit(2500, 1.025M);
        Console.WriteLine("Mitt konto: {0}", myAccount.ToString());

        // Anropa vår static metod direkt på klassen...
        BankAccount.MyFancyMethod();
    }
}
