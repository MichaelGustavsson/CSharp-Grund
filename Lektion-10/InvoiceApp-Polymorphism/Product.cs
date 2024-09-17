namespace InvoiceApp;

public class Product
{
  /* PROPERTIES */
  public int ItemNumber { get; private set; }
  public string Name { get; private set; } = "";
  public decimal Price { get; private set; }

  /* CONSTRUCTORS */
  public Product() { }

  public Product(int itemNumber)
  {
    ItemNumber = itemNumber;
    FindProduct();
  }

  public void AddNewProduct(int itemNumber, string name, decimal price)
  {
    // Kontrollera att artikelnummer inte redan existerar...
    // Även innehåller rätt antal siffror(tecken)...
    ItemNumber = itemNumber;
    // Kontrollerar att namngivning av våra produkter följer riktlinjerna...
    Name = name;
    // Kontrollera så att pris till kund inte understiger 30% marginal för vårt inköp av produktion ifrån leverantör...
    Price = price;
  }
  /* METHODS */
  public override string ToString()
  {
    return $"Artikelnummer: {ItemNumber} Produktnamn: {Name} Pris/st: {Price}";
  }

  /* PRIVATE METHODS */
  private void FindProduct()
  {
    // Vår lilla databas...😁
    if (ItemNumber == 445869)
    {
      Name = "Kofot";
      Price = (decimal)149.00;
    }
    else if (ItemNumber == 445878)
    {
      Name = "Slägga";
      Price = (decimal)1095.00;
    }
    else
    {
      throw new ArgumentException($"Kunde inte hitta någon produkt med artikelnummer: {ItemNumber}");
    }
  }
}
