namespace BankApp;

public class BankAccount
{
  // PUBLIKA FÄLT - KLASSENS INFORMATION(DATA) //
  private string _accountNumber;
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
    // Här kan vi nu sätta eller ge värden åt våra privata fält
    // som ett objekt kan behöva som startvärde när objektet skapas
    // ifrån klassen...
    _accountNumber = "";  // Vi sätter _accountNumber till en tom sträng
    _balance = 0;         // Vi sätter _balance till det numeriska värdet 0
    _interestRate = (decimal)0.0275;  // Vi sätter _interestRate till värdet 0.0275, 
                                      // men måste konvertera värdet till decimal på 
                                      // grund av att när vi skriver ett värde direkt
                                      // kallas även för literal så är alltid
                                      // flyttal av typen double i C#.
  }

  // Här skapar vi en konstruktor till, vi överlagrar vår första konstruktor
  // genom att ange att denna konstruktor tar ett argument av typen string
  // och namnges till accountNumber.
  // så vi ser att en konstruktor beter sig precis som vilken annan metod som helst i C#
  public BankAccount(string accountNumber)
  {
    // Här får _accountNumber det värde som kommer in via argument när konstruktorn anropas...
    _accountNumber = accountNumber;
    _balance = 0;
    _interestRate = (decimal)0.0275;
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
