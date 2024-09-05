namespace BankApp;

public class BankAccount
{
  // PUBLIKA FÄLT - KLASSENS INFORMATION(DATA) //
  private string _accountNumber = "";
  private decimal _balance;
  public decimal _interestRate;
  // -------------------------------------------------------------- //

  // GETTERS OCH SETTERS //
  // OBSERVERA ATT OM FÄLTEN SKA BÅDE KUNNA SKRIVAS TILL OCH LÄSAS IFRÅN
  // SÅ SKAPAS DET TVÅ METODER GET??? OCH SET???
  public string GetAccountNumber()
  {
    return _accountNumber;
  }

  public void SetAccountNumber(string accountNumber)
  {
    _accountNumber = accountNumber;
  }

  // OM DET ENDAST SKA GÅ ATT LÄSA UT ETT FÄLTS VÄRDE SÅ UTELÄMNAS METODEN SET???
  // DÅ BLIR FÄLTET SKRIVSKYDDAT UTIFRÅN...
  public decimal GetBalance()
  {
    return _balance;
  }

  public decimal GetInterestRate()
  {
    return _interestRate;
  }

  public void SetInterestRate(decimal rate)
  {
    _interestRate = rate;
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
