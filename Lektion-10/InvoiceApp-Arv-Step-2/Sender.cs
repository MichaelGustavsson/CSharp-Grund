﻿namespace InvoiceApp;

public class Sender : Customer
{
  /* PROPERTIES */
  public string ReferenceEmail { get; set; } = "";

  /* CONSTRUCTORS */
  public Sender()
  {
    Find();
  }

  /* METHODS */
  public override string ToString()
  {
    return $"Avsändare: {Name} Address: {Address} Telefon: {Phone} Vår referens: {Reference}";
  }
}
