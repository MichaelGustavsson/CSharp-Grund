using InvoiceLib;
using Microsoft.AspNetCore.Mvc;

namespace Westcoast_shop.Controllers;

public class InvoiceController : Controller
{
    // Min lista av fakturor
    private List<Invoice> _invoices = [];

    public InvoiceController()
    {
        Invoice invoice = new Invoice(1, 1);
        invoice.AddInvoiceItem(new InvoiceItem(4, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(1, new Product(445878)));
        // Lägg till fakturan till listan...
        _invoices.Add(invoice);

        invoice = new Invoice(1, 2);
        invoice.AddInvoiceItem(new InvoiceItem(2, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(3, new Product(445878)));
        _invoices.Add(invoice);

        invoice = new Invoice(1, 3);
        invoice.AddInvoiceItem(new InvoiceItem(8, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(2, new Product(445878)));
        _invoices.Add(invoice);

        invoice = new Invoice(1, 4);
        invoice.AddInvoiceItem(new InvoiceItem(12, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(10, new Product(445878)));
        _invoices.Add(invoice);

        invoice = new Invoice(1, 5);
        invoice.AddInvoiceItem(new InvoiceItem(12, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(10, new Product(445878)));
        _invoices.Add(invoice);

        invoice = new Invoice(1, 6);
        invoice.AddInvoiceItem(new InvoiceItem(12, new Product(445869)));
        invoice.AddInvoiceItem(new InvoiceItem(10, new Product(445878)));
        _invoices.Add(invoice);
    }

    public ActionResult Index()
    {
        return View(_invoices);
    }

    public ActionResult Details(int id)
    {
        var foundInvoice = _invoices.Where(invoice => invoice.InvoiceNumber == id).FirstOrDefault();
        return View(foundInvoice);
    }
}

