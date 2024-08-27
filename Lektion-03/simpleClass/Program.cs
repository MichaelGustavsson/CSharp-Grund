namespace simpleClass;

class Program
{
    static void Main()
    {
        var myAccount = new BankAccount();
        var yourAccount = new BankAccount();

        var badAccount = yourAccount;

        // Visa saldot...
        Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", yourAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", badAccount.ShowBalance());

        // Sätt in pengar...
        myAccount.Deposit(100);
        yourAccount.Deposit(500);
        badAccount.Deposit(200);

        // Visa saldot...
        Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", yourAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", badAccount.ShowBalance());

        // Ta ut pengar...
        myAccount.WithDraw(25);
        yourAccount.WithDraw(275);
        badAccount.WithDraw(100);

        // Visa saldot...
        Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", yourAccount.ShowBalance());
        Console.WriteLine("Aktuellt saldo: {0}", badAccount.ShowBalance());

    }
}

public class BankAccount
{
    // Skapat informationshanterare
    // Variabel för att hålla reda på saldot...
    int balance = 0;

    // Metoder, Beteende...

    // Metod för att sätta in pengar...
    public void Deposit(int value)
    {
        // balance = balance + value;
        balance += value;
    }

    // Metod för att visa saldot...
    public int ShowBalance()
    {
        return balance;
    }

    // Metod för att ta ut pengar...
    public void WithDraw(int value)
    {
        // balance = balance - value;
        balance -= value;
    }
}