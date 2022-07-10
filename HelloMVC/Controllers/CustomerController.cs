using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer c = new Customer();
            c.CustomerID = "111";
            c.FullName = "พรพิมล หลักวิโรจน์";
            c.Address = "นนทบุรี";

            //CustomerLists
            var CustomerLists = new List<Customer>();
            CustomerLists.Add(new() { CustomerID = "101", FullName = "วรยศ เฟื่องการงาน", Address = "กรงเทพ"});
            CustomerLists.Add(new() { CustomerID = "102", FullName = "พรพิมล หลักวิโรจน์", Address = "กรงเทพ" });
            CustomerLists.Add(new() { CustomerID = "103", FullName = "ชาโคล บี้", Address = "กรงเทพ" });

            return View(CustomerLists);
        }
    }
}
