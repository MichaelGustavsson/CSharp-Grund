using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;

public class InvoicesController : Controller
{
    private List<Invoice> _invoices = [];
    private readonly string _ordersPath;
    private readonly string _invoicesPath;

    public InvoicesController(IWebHostEnvironment environment)
    {
        var wwwroot = environment.WebRootPath;
        _invoicesPath = string.Concat(wwwroot, "/Data/invoices.json");
        _ordersPath = string.Concat(wwwroot, "/Data/orders.json");

        GetInvoices(_invoicesPath);
    }
    public ActionResult Index()
    {
        return View(_invoices);
    }

    public ActionResult Create(int orderId)
    {
        var orders = GetOrders(_ordersPath);
        var order = orders.FirstOrDefault(o => o.OrderId == orderId);
        var invoice = CreateInvoice(order!);
        invoice.InvoiceNumber = _invoices.Count + 1;

        _invoices.Add(invoice);

        Storage.WriteInvoicesJson(_invoicesPath, _invoices);

        return RedirectToAction("Index");
    }

    private Invoice CreateInvoice(SalesOrder order)
    {
        var invoice = new Invoice(order.Customer!);
        foreach (var item in order.OrderItems!)
        {
            invoice.AddInvoiceItem(new InvoiceItem(item.Quantity, item.Product!));
        }

        return invoice;
    }
    private void GetInvoices(string path)
    {
        _invoices = Storage.ReadInvoicesJson(path);
    }

    private List<SalesOrder> GetOrders(string path)
    {
        return Storage.ReadJson(path);
    }

}

