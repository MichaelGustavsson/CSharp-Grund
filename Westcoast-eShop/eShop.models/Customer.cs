namespace eShop.models;

public class Customer
{
  /* PROPERTIES */
  public int CustomerId { get; set; }
  public string? AddressLine { get; set; }
  public string? City { get; set; }
  public DateTime CreatedAt { get; set; }
  public string? Email { get; set; }
  public string? FirstName { get; set; }
  public DateTime LastBuy { get; set; }
  public string? LastName { get; set; }
  public string? Phone { get; set; }
  public string? PostalCode { get; set; }

  /* METHODS */
  public override string ToString()
  {
    return $"{FirstName} {LastName}";
  }
}