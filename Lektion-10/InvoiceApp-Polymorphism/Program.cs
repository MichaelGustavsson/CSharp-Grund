namespace InvoiceApp;

class Program
{
    static void Main()
    {
        // Customer customer = new Customer();
        // Sender sender = new Sender();
        // Company company = new Company();

        Customer customer = new Customer();
        Customer sender = new Sender();
        Customer company = new Company();

        customer.Find();

        Console.WriteLine("Customer info");
        Console.WriteLine(customer);

        sender.Find();
        Console.WriteLine("Customer info");
        Console.WriteLine(sender);

        company.Find();
        Console.WriteLine("Compant info");
        Console.WriteLine(company);

        // sender.Find();

        // Console.WriteLine("Sender info");
        // Console.WriteLine(sender);

        // company.Find();

        // Console.WriteLine("Company info");
        // Console.WriteLine(company);
    }
}
