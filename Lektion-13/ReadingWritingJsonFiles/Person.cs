namespace ReadingWritingJsonFiles;

public class Person
{
  public DateTime CreatedAt { get; set; }
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string Email { get; set; } = "";
  public string Phone { get; set; } = "";
  public int Age { get; set; }
  public Address Address { get; set; } = new();

  public override string ToString()
  {
    return $"{CreatedAt} {FirstName} {LastName} {Email} {Phone} {Age}";
  }

}