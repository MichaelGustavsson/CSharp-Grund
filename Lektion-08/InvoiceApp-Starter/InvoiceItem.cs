namespace InvoiceApp;

public class InvoiceItem
{
  /* PROPERTIES */
  public int ProductId { get; set; }
  public string ProductName { get; set; }
  public decimal Price { get; set; }
  public int NumberOfItems { get; set; }
  public decimal LineSum { get; set; }

  /* CONSTRUCTORS */
  // Default constructor...
  public InvoiceItem()
  {
    ProductName = "";
  }

  /* METHODS */
  public void AddProduct(int id, string name, int numberOfItems, decimal price)
  {
    // Flytta argumentens(parametrarnas) värde till egenskaperna...
    ProductId = id;
    ProductName = name;
    NumberOfItems = numberOfItems;
    Price = price;

    LineSum = Price * NumberOfItems;
  }

  public override string ToString()
  {
    return $"Produkt: {ProductName} - Antal: {NumberOfItems} - Pris/st: {Price} Radsumma: {LineSum}";
  }
}
