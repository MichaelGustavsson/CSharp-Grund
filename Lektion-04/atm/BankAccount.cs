using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace atm;

// Public innebär att klassen är tillgänglig
// överallt...
// Klassen är egentligen en mall
public class BankAccount
{
  // Deklarera en variabel för att lagra
  // aktuellt saldo
  int balance = 0;

  // Lagra alla uttag i någon typ av lista...
  // ArrayList transactions = [];
  List<int> transactions = new List<int>();
  // List<int> transactions = [];

  // Metoder...
  // Metod för att sätta in pengar på vårt konto...
  // Metod Deposit ska inte returnera någonting
  // därför sätter void som returvärde
  // Deposit behöver ha in mängden pengar som vi ska sätta in
  // via amount argumentet.
  public void Deposit(int amount)
  {
    // Läs ut vad som finns just nu i balance variabeln
    // Sedan addera värdet som finns i amount argumentet
    balance += amount;
    // balance = balance + amount;
  }

  // Metod som låter oss ta ut pengar ifrån kontot...
  // Uppdatera saldot(balance)...
  public void WithDraw(int amount)
  {
    if (balance > amount)
    {
      balance -= amount;
      // Lägger till transaktionen i listan transactions...
      transactions.Add(amount);
    }
    else
    {
      throw new ArgumentException("Uttag medges ej.");
    }
  }

  // Metod för att visa aktuellt saldo...
  public int DisplayBalance()
  {
    return balance;
  }

  // Metod för att hämta aktuella transaktioner...
  public List<int> DisplayTransactions()
  {
    // Returnerar listan av transaktioner...
    return transactions;
  }
}