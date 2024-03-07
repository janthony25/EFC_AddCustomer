using EFC_AddCustomer.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFC_AddCustomer.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _db;

        public InvoiceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
