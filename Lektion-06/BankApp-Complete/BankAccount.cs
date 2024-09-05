namespace BankApp;

public class BankAccount
{
  // AUTO-PROPERTIES //
  // OBSERVERA ATT VI SKAPAR ETT 'PUBLIKT' NAMN FÖR VÅRA FÄLT!
  public string AccountNumber { get; set; }
  public decimal Balance { get; private set; }
  public decimal InterestRate { get; }

  // ---------------------------------------------------------------//
  // KONSTRUKTORER(CONSTRUCTORS) //
  // KONSTRUKTORER ELLER CONSTRUCTORS ÄR MYCKET SPECIELLA METODER
  // SOM ANVÄNDS I KLASSER FÖR ATT SÄTTA FÄLT TILL KORREKTA VÄRDEN
  // NÄR ETT OBJEKT SKAPAS IFRÅN KLASSEN. KALLAS ÄVEN FÖR ATT
  // INITIERA FÄLT TILL ETT KORREKT TILLSTÅND(STATE).
  // EN KONSTRUKTOR METOD ÄR EN METOD MED EXAKT SAMMA NAMN SOM 
  // KLASSEN OCH SOM INTE RETURNERAR NÅGOT.

  // Här är en standard konstruktor för vår 'BankAccount' klass...
  // vad det menas med att är den tar inga argument men sätter
  // värden på vårt interna tillstånd, våra fält...
  public BankAccount()
  {
    AccountNumber = "";
    Balance = 0;
    InterestRate = (decimal)0.0275;
  }

  // Här skapar vi en konstruktor till, vi överlagrar vår första konstruktor
  // genom att ange att denna konstruktor tar ett argument av typen string
  // och namnges till accountNumber.
  // så vi ser att en konstruktor beter sig precis som vilken annan metod som helst i C#
  public BankAccount(string accountNumber)
  {
    AccountNumber = accountNumber;
    Balance = 0;
    InterestRate = (decimal)0.0275;
  }

  // ---------------------------------------------------------------//
  // PUBLIKA METODER - VAD SKA KLASSEN KUNNA UTFÖRA //
  // KALLAS FÖR BETEENDE I OOP //

  // Metod för att sätta in pengar på kontot...
  public void Deposit(decimal amount)
  {
    // Addera mängden som skall sättas in på Balance fältets
    // aktuella värde
    Balance += amount;

    // Kontrollera om vi har mer än 1000kr på kontot
    // i så fall ska vi få lite ränta på vårt konto...
    if (Balance > 1000 && Balance <= 2000)
    {
      Balance *= 1 + InterestRate;
    }
    else if (Balance > 2000)
    {
      // Om vi har mer än 2000kr på kontot så ska räntan justeras upp med 0.005 procent enheter...
      // InterestRate += 0.005;
      // Tyvärr går inte räntan att justera, den är automatiskt satt till 'readonly'
      // i och med att vi inte har nyckelordet 'set' på egenskapen InterestRate.
    }
  }

  // Metod för att ta ut pengar ifrån kontot...
  public void WithDraw(decimal amount)
  {
    // Kontrollera så att värdet på 'Balance' är större än vad
    // som ska tas ut...
    if (Balance > amount)
    {
      Balance -= amount;
    }
    // Annars så 'kastar' vi ett fel tillbaka till den del av
    // applikationen som försöker ta ut pengar...
    else
    {
      throw new ArgumentException("Uttag medges ej.");
    }
  }

  // Här åsidosätter vi den inbyggda metoden ToString()
  // som finns på alla datatyper i .NET
  public override string ToString()
  {
    // Vi skapar ett eget meddelande som vi vill kunna visa
    // när ToString() metoden anropas...
    return $"Kontonummer: {AccountNumber} Saldo: {Balance}";
  }
}
