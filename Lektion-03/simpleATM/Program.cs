namespace simpleATM;

class Program
{
    static void Main()
    {
        // Deklarera en variabel för att
        // hålla reda på saldot...
        int balance;

        // Insättning...
        Console.WriteLine("Ange hur mycket du vill sätta in");
        string deposit = Console.ReadLine()!;
        balance = int.Parse(deposit);

        DisplayBalance(balance);

        // Uttag...
        Console.WriteLine("Hur mycket vill du ta ut?");
        string withdraw = Console.ReadLine()!;
        // Beräkna nytt saldo...
        balance = balance - int.Parse(withdraw);
        // balance -= int.Parse(withdraw);
        DisplayBalance(balance);

    }

    // Metod som skriver ut saldot och tar in aktuellt saldo
    // som argument...
    static void DisplayBalance(int balance)
    {
        // Visa saldot igen...
        Console.WriteLine("Aktuellt saldo: " + balance);
    }
}
