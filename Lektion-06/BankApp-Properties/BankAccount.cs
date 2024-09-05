namespace BankApp;

public class BankAccount
{
  // PUBLIKA FÄLT - KLASSENS INFORMATION(DATA) //
  private string _accountNumber = "";
  private decimal _balance;
  private decimal _interestRate;
  // -------------------------------------------------------------- //

  // PROPERTIES //
  // OBSERVERA ATT VI SKAPAR ETT 'PUBLIKT' NAMN FÖR VÅRA FÄLT!
  // INOM MÅSVINGARNA (KODBLOCKET) SÅ ANVÄNDER VI NYCKELORDEN
  // get ELLER set FÖR ATT DEFINIERA OM DET SKA GÅ ATT LÄSA OCH/ELLER
  // TILL OCH IFRÅN FÄLTEN...
  public string AccountNumber
  {
    get { return _accountNumber; }
    set { _accountNumber = value; }
  }

  // Balance OCH InterestRate SAKNAR set NYCKELORDET VILKET BETYDER
  // ATT DET ENDAST GÅR ATT LÄSA UT VÄRDET PÅ KOPPLAT FÄLT...
  public decimal Balance
  {
    get { return _balance; }
  }

  public decimal InterestRate
  {
    get { return _interestRate; }
  }

  // ---------------------------------------------------------------//
  // PUBLIKA METODER - VAD SKA KLASSEN KUNNA UTFÖRA //
  // KALLAS FÖR BETEENDE I OOP //

  // Metod för att sätta in pengar på kontot...
  public void Deposit(decimal amount)
  {
    // Addera mängden som skall sättas in på Balance fältets
    // aktuella värde
    _balance += amount;
  }

  // Metod för att ta ut pengar ifrån kontot...
  public void WithDraw(decimal amount)
  {
    // Kontrollera så att värdet på 'Balance' är större än vad
    // som ska tas ut...
    if (_balance > amount)
    {
      _balance -= amount;
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
    return $"Kontonummer: {_accountNumber} Saldo: {_balance}";
  }
}
