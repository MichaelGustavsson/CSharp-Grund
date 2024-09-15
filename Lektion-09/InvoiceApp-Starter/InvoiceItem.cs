namespace InvoiceApp;

public class InvoiceItem
{
  /* PROPERTIES */
  public int NumberOfItems { get; set; }
  public decimal LineSum { get; set; }
  // Composition...
  public Product Product { get; set; }

  /* CONSTRUCTORS */
  public InvoiceItem(int numberOfItems, Product product)
  {
    Product = product;
    NumberOfItems = numberOfItems;
    LineSum = Product.Price * NumberOfItems;
  }

  /* METHODS */
  public override string ToString()
  {
    return $"Produkt: {Product.ToString()} - Antal: {NumberOfItems} Radsumma: {LineSum}";
  }
}
