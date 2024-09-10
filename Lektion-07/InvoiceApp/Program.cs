﻿namespace InvoiceApp;

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

        // Skapa ett anonymt objekt som representerar en fakturarad..
        // Anonyma objekt skapas med hjälp av nyckelordet
        // new och sedan {}
        var item = new { ProductName = "Kofot", Price = 149.00, Amount = 4, LineSum = 596.00 };
        invoice.AddInvoiceItem(item);
        item = new { ProductName = "Slägga", Price = 1095.00, Amount = 1, LineSum = 1095.00 };
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
