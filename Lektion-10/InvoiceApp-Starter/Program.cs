namespace InvoiceApp;

class Program
{
    static void Main()
    {
        // Skapa ett objekt ifrån klassen Invoice...
        // variabeln invoice ska ha en NY(new) kopia(instans)
        // av klassen Invoice...
        Invoice invoice = new Invoice(981256);
        /* FAKTURA RADER */
        try
        {
            invoice.AddInvoiceItem(new InvoiceItem(4, new Product(445869)));
            invoice.AddInvoiceItem(new InvoiceItem(1, new Product(445878)));
            // invoice.AddInvoiceItem(new InvoiceItem(1, new Product(445879)));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ooops det blev lite fel: {0}", ex.Message);
        }


        // För varje invoiceItem(fakturarad) som finns
        // i invoice.InvoiceItems(lista av fakturader i objektet)
        // skriv ut varje fakturarad separat...
        foreach (var invoiceItem in invoice.InvoiceItems)
        {
            Console.WriteLine("Fakturarader: {0}", invoiceItem);
        }

        Console.WriteLine(invoice);
    }
}
