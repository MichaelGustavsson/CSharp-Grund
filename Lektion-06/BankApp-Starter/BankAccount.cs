namespace BankApp;

public class BankAccount
{
  public string AccountNumber = "";
  public decimal Balance;
  public decimal InterestRate;

  public void Deposit(decimal amount)
  {
    Balance += amount;
  }

  public void WithDraw(decimal amount)
  {
    Balance -= amount;
  }

  public override string ToString()
  {
    return $"Kontonummer: {AccountNumber} Saldo: {Balance}";
  }
}
