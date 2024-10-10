using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class InvoicesController : Controller
    {
        // GET: InvoicesController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

    }
}
