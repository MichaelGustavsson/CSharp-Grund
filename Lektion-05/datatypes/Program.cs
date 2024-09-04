using Microsoft.VisualBasic;

namespace datatypes;

class Program
{
    static void Main()
    {
        // .NET Base Type...

        Console.WriteLine(".NET Base Type-------------------------");
        object obj = new();

        Console.WriteLine("HashCode: {0}", obj.GetHashCode());
        Console.WriteLine("Type: {0}", obj.GetType());

        // Integer methods...
        //------------------------------------------------------------
        Console.WriteLine("Integer (int)-------------------------");
        int x = 10;

        Console.WriteLine("HashCode: {0}", x.GetHashCode());
        Console.WriteLine("Type: {0}", x.GetType());
        Console.WriteLine("CompareTo: {0}", x.CompareTo(20));
        Console.WriteLine("ToString: {0}", x.ToString());

        // String methods...
        //------------------------------------------------------------

        Console.WriteLine("String Type-------------------------");
        string name = "Michael Gustavsson";
        Console.WriteLine("HashCode: {0}", name.GetHashCode());
        Console.WriteLine("Type: {0}", name.GetType());

        string newName = name.Replace("M", "m");
        Console.WriteLine("Replace: {0}", newName);

        // string y = "a" + "b" + "c";

        string concatName = string.Concat("Nisse", " ", "Nilsson"); ;
        Console.WriteLine("Concat: {0}", concatName);

        // Date DateTime methods...
        //------------------------------------------------------------
        Console.WriteLine("DateTime Type-------------------------");

        // DateTime myDate = DateTime.Today;
        DateTime myDate = DateTime.Now;
        Console.WriteLine("Aktuell datum och tid: {0}", myDate);
        Console.WriteLine("Aktuell datum: {0}", myDate.Date);
        Console.WriteLine("Aktuell tid: {0}", myDate.TimeOfDay);
        Console.WriteLine("Aktuell datum i framtiden: {0}", myDate.AddDays(1));
        Console.WriteLine("Aktuell datum i framtiden: {0}", myDate.AddDays(-1));
        Console.WriteLine("Aktuell datum i framtiden: {0}", myDate.AddMonths(12));
        Console.WriteLine("Aktuell år: {0}", myDate.Year);
        Console.WriteLine("Aktuell månad: {0}", myDate.Month);
        Console.WriteLine("Aktuell dag: {0}", myDate.Day);
        Console.WriteLine("Aktuell dag i veckan: {0}", myDate.DayOfWeek);
        Console.WriteLine("Aktuell dag på året: {0}", myDate.DayOfYear);
    }
}
