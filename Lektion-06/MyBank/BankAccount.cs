using System.Security.Cryptography.X509Certificates;

namespace MyBank;

public class BankAccount
{
  // Deklarera tillståndet/data/informationen som ska lagras i objekten...
  // Data fält/fields...
  // private decimal _balance;
  // private readonly decimal _interestRate;
  // private string _accountNumber;
  // private readonly DateTime _createdDate;

  public decimal Balance { get; set; }
  public string AccountNumber { get; set; }
  public decimal InterestRate { get; }

  // Properties...
  // public string AccountNumber
  // {
  //   get
  //   {
  //     // Logik för att fixa till retur värdet...
  //     return _accountNumber;
  //   }
  //   set
  //   {
  //     // Logik/kod för att validera kontonummer... 
  //     _accountNumber = value;
  //   }
  // }

  // public string CreateAt
  // {
  //   get { return _createdDate.ToShortDateString(); }
  // }

  // public decimal Balance
  // {
  //   get { return _balance; }
  // }

  // public decimal InterestRate
  // {
  //   get { return _interestRate; }
  // }

  // Getters och Setters...

  // // Getter...
  // public decimal GetBalance()
  // {
  //   return _balance;
  // }

  // // Getter...
  // public decimal GetInterestRate()
  // {
  //   return _interestRate;
  // }

  // // Getter...
  // public string GetAccountNumber()
  // {
  //   return _accountNumber;
  // }

  // // Setter...
  // public void SetAccountNumber(string accountNumber)
  // {
  //   _accountNumber = accountNumber;
  // }

  // Constructor metoder...
  // Uppsättning av tillståndet i objektet...

  // Default constructor...
  public BankAccount()
  {
    InterestRate = 1.025M;
    AccountNumber = "";

    // _createdDate = DateTime.Now;
    // _balance = 0.00M;
    // _interestRate = 0.00M;
    // _accountNumber = "";
  }

  // Överlagrade konstruktor...
  // public BankAccount(string accountNumber)
  // {
  //   _createdDate = DateTime.Now;
  //   _balance = 0.00M;
  //   _interestRate = 0.00M;
  //   _accountNumber = accountNumber;
  // }

  // public BankAccount(string accountNumber, decimal initialBalance)
  // {
  //   _createdDate = DateTime.Now;
  //   _balance = initialBalance;
  //   _interestRate = 0.00M;
  //   _accountNumber = accountNumber;
  // }

  // public BankAccount(string accountNumber, decimal initialBalance, decimal interestRate)
  // {
  //   _createdDate = DateTime.Now;
  //   _balance = initialBalance;
  //   _interestRate = interestRate;
  //   _accountNumber = accountNumber;
  // }

  // Betende/Vad ska vi kunna utföra med objektet...


  public void Deposit(int amount, decimal interest)
  {
    Balance += amount;

    if (Balance > 1000)
    {
      // _interestRate = (decimal)1.025;
      // _interestRate = 1.025M;
      Balance *= InterestRate;
    }
  }

  public void WithDraw(int amount)
  {
    if (Balance > amount)
    {
      Balance -= amount;
    }
    else
    {
      throw new ArgumentException("Tyvärr uttag medges ej.");
    }
  }

  // Static metod direkt på/i klassen...
  public static void MyFancyMethod()
  {

  }

  public override string ToString()
  {
    // return AccountNumber + " " + Balance;
    return $"{AccountNumber} - {Balance}";
    // return string.Concat(AccountNumber, " ", Balance);
  }
}
