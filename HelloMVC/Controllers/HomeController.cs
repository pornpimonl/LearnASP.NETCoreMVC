using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HelloMVC.Models.ViewModels;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomersProductsViewModels data = new CustomersProductsViewModels();
            data.GetCustomers = (IEnumerable<Customer>)GetAllCustomers();
            data.GetProducts = (IEnumerable<Product>)GetAllProducts();
            
            //ValueTuple
            var FullName = ("พรพิมล", "หลักวิโรจน์");
            ViewData["myname"] = FullName.Item1 + " " + FullName.Item2;
            var FullName2 = (FirstName:"พรพิมล", LastName:"หลักวิโรจน์");
            ViewData["myname2"] = FullName2.FirstName + " " + FullName2.LastName;

            //Local Function
            int x = 200;
            int y = 300;
            var result = 0;

            AddData(x, y);

            void AddData(int num1, int num2)
            {
                result = num1 + num2;
            }
            ViewData["result"] = result;

            ViewData["AllCustomers"] = GetAllCustomers();
            ViewData["AllProducts"] = GetAllProducts();

            return View(data);
        }

        private object GetAllProducts()
        {
            List<Product> lstproducts = new List<Product>();
            lstproducts.Add(new Product
            {
                ProductID = 1,
                ProductName = "a",
                ProductPrice = 3
            });
            lstproducts.Add(new Product
            {
                ProductID = 1,
                ProductName = "a",
                ProductPrice = 3
            });
            return lstproducts;
        }


        private object GetAllCustomers()
        {
            List<Customer> lstcustomers = new List<Customer>();
            lstcustomers.Add(new Customer
            {
                CustomerID = "A001",
                FullName = "joy",
                Address = "a"

            });
            lstcustomers.Add(new Customer
            {
                CustomerID = "A002",
                FullName = "joy2",
                Address = "a2"

            });
            lstcustomers.Add(new Customer
            {
                CustomerID = "A0013",
                FullName = "joy3",
                Address = "a3"

            });
            return lstcustomers;
        }

        public IActionResult Info() => View();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
