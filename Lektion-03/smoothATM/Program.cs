namespace smoothATM;

using System.Collections;

class Program
{
    static void Main()
    {
        try
        {
            var myAccount = new BankAccount();

            // Visa saldot...
            Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());

            // Sätt in pengar...
            myAccount.Deposit(500);

            // Visa saldot...
            Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());

            // Ta ut pengar...
            myAccount.WithDraw(25);
            myAccount.WithDraw(25);
            myAccount.WithDraw(25);
            myAccount.WithDraw(75);

            // Visa saldot...
            Console.WriteLine("Aktuellt saldo: {0}", myAccount.ShowBalance());

            // Visa transaktioner...
            Console.WriteLine("Alla transaktioner {0}", myAccount.DisplayTransactions());
            Console.WriteLine("Alla transaktioner");
            Console.WriteLine("-------------------------");

            // foreach loop, för varje element i angiven lista(array) gör något...
            var transactions = myAccount.DisplayTransactions();
            foreach (var tran in transactions)
            {
                Console.WriteLine("Transaktionsvärde: {0}", tran);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class BankAccount
{
    // Skapat informationshanterare
    // Variabel för att hålla reda på saldot...
    int balance = 0;

    // Använd en dynamisk array...
    ArrayList transactions = new ArrayList();

    // Metoder, Beteende...

    // Metod för att sätta in pengar...
    public void Deposit(int value)
    {
        // balance = balance + value;
        balance += value;
    }

    public ArrayList DisplayTransactions()
    {
        return transactions;
    }

    // Metod för att visa saldot...
    public int ShowBalance()
    {
        return balance;
    }

    // Metod för att ta ut pengar...
    public void WithDraw(int value)
    {
        // if(villkoret) {vägriktning}
        if (balance < value)
        {
            throw new Exception("Du har inte tillräckligt på kontot!");
        }
        else
        {
            // balance = balance - value;
            balance -= value;
            transactions.Add(value);
        }
    }
}