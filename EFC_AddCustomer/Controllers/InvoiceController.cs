using EFC_AddCustomer.Data;
using EFC_AddCustomer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var customerWithItems = _db.CustomerNames.Include(c => c.Items).ToList();
            return View(customerWithItems);
        }
    }
}
