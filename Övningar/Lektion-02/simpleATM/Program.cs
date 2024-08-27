namespace simpleATM;

class Program
{
    static void Main(string[] args)
    {
        int balance;

        balance = Deposit("Hur mycket vill du sätta in?");

        DisplayBalance(balance);

        var withDraw = WithDraw("Hur mycket vill du ta ut?");
        balance -= withDraw;

        DisplayBalance(balance);
    }

    static int Deposit(string message)
    {
        Console.WriteLine("Sätt in pengar");
        var deposit = Console.ReadLine();
        return int.Parse(deposit!);
    }

    static int WithDraw(string message)
    {
        Console.WriteLine("Hur mycket vill du ta ut?");
        var withDraw = Console.ReadLine();
        return int.Parse(withDraw!);
    }

    static void DisplayBalance(int balance)
    {
        Console.WriteLine("Saldo " + balance);
    }
}
