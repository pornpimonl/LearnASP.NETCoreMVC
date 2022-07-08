using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer c = new Customer();
            c.CustomerID = 111;
            c.FullName = "พรพิมล หลักวิโรจน์";
            c.Address = "นนทบุรี";
            
            return View(c);
        }
    }
}
