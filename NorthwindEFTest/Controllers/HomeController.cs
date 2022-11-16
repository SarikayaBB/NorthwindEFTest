using Microsoft.AspNetCore.Mvc;
using NorthwindEFTest.Models;
using System.Diagnostics;

namespace NorthwindEFTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindContext _db;

        public HomeController(NorthwindContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View(_db.Customers.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAllJson()
        {
            List<Customer> list = _db.Customers.ToList<Customer>();
            return Json(new { data = list });
        }
    }
}