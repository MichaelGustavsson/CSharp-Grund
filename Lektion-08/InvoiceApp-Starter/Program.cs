using Microsoft.VisualBasic;

namespace InvoiceApp;

class Program
{
    static void Main()
    {
        // Skapa ett objekt ifrån klassen Invoice...
        // variabeln invoice ska ha en NY(new) kopia(instans)
        // av klassen Invoice...
        Invoice invoice = new Invoice();

        Console.WriteLine(invoice.ToString());

        /* KUND INFORMATION */
        invoice.CustomerNumber = 981256;
        invoice.CustomerName = "Bosse Kofot";
        invoice.CustomerAddress = "Rånarvägen 1";
        invoice.CustomerPostalCode = "666 78";
        invoice.CustomerCity = "Härlanda";
        invoice.CustomerReference = "Sickan Karlsson";

        /* FÖRETAGS INFORMATION */
        invoice.SenderName = "Vanhedens järnhandel";
        invoice.SenderAddress = "Stålgatan 14";
        invoice.SenderPostalCode = "888 98";
        invoice.SenderCity = "Hålan";
        invoice.SenderPhone = "073-444222";
        invoice.SenderReference = "Dynamit Harry";
        invoice.SenderReferenceEmail = "harry@gmail.com";

        /* FAKTURA RADER */

        // Skapa en ny instans(kopia) av klassen InvoiceItem...
        InvoiceItem item = new InvoiceItem();
        // Använd metoden AddProduct i InvoiceItem för att lägga till en ny produkt och antal...
        item.AddProduct(1, "Kofot", 4, (decimal)149.00);
        // Lägg till den nya fakturaraden till fakturans lista av fakturarader...
        invoice.AddInvoiceItem(item);
        // Skapa ytterligare ett nytt objekt av klassen InvoiceItem
        item = new InvoiceItem();
        // Lägg till en ny produkt
        item.AddProduct(2, "Slägga", 1, (decimal)1095.00);
        // Lägg till den nya fakturaraden till listan av fakturarader i fakturan...
        invoice.AddInvoiceItem(item);

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
