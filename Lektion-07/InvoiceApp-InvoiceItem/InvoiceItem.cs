namespace InvoiceApp;

public class InvoiceItem
{
  /* PROPERTIES */
  public int ProductId { get; set; }
  public string ProductName { get; set; }
  public decimal Price { get; set; }
  public int Amount { get; set; }
  public decimal LineSum { get; set; }

  /* CONSTRUCTORS */
  // Default constructor...
  public InvoiceItem()
  {
    ProductName = "";
  }

  /* METHODS */
  public void AddProduct(int id, string name, int amount, decimal price)
  {
    // Flytta argumentens(parametrarnas) värde till egenskaperna...
    ProductId = id;
    ProductName = name;
    Amount = amount;
    Price = price;

    LineSum = Price * Amount;
  }

  public override string ToString()
  {
    return $"Produkt: {ProductName} - Antal: {Amount} - Pris/st: {Price} Radsumma: {LineSum}";
  }
}
