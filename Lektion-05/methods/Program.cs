namespace methods;

class Program
{
    static void Main()
    {
        MyMethod();
        MyMethod("Nisse");
        MyMethod("Nisse", 25);

        // int sum = Sum(1, 4);
        // Console.WriteLine("Summan är: {0}", sum);
        Console.WriteLine("Summan är: {0}", Sum(1, 4));
        Console.WriteLine("Summan är: {0}", Sum(1, 4, 5));

        int result = Sum2([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]);

        Console.WriteLine("Sum2 ger oss följande summa: {0}", result);

        double interest = 1.025;
        double calculatedBalance;
        int saldo = CalculateBalance(250, interest, out calculatedBalance);

        Console.WriteLine("Saldo: {0} Interest: {1} Calculated balance: {2}",
            saldo, interest, calculatedBalance);

        // foreach (double value in CalculateBalance(250))
        // {
        //     Console.WriteLine("CalculateBalance: {0}", value);
        // }

    }

    static void MyMethod()
    {
        Console.WriteLine("Metod som inte gör något!");
    }

    // Överlagrad metod.
    static void MyMethod(string name)
    {
        Console.WriteLine("Metod som visar argumentets värde: {0}", name);
    }

    static void MyMethod(string name, int age)
    {
        Console.WriteLine("Metod som visar argumentets värde: {0} och ålder: {1}", name, age);
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }

    static int Sum(int x, int y, int z)
    {
        return x + y + z;
    }

    static int Sum2(int[] numbers)
    {
        int result = 0;

        // for (int i = 0; i < numbers.Length; i++) { }
        foreach (int i in numbers)
        {
            result += i;
        }

        return result;
    }

    // Bad Practice för så lite som ska returneras...
    // -----------------------------------------------
    // static List<double> CalculateBalance(int saldo)
    // {
    //     double interest = saldo * 1.05;
    //     // List<double> result = new List<double>();
    //     // List<double> result = new();
    //     List<double> result = [];

    //     result.Add(saldo);
    //     result.Add(interest);

    //     return result;
    // }

    static int CalculateBalance(int saldo, double interest, out double calcalatedBalance)
    {
        calcalatedBalance = saldo * interest;
        return saldo;
    }
}
