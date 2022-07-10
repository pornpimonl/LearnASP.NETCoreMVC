using System.Collections.Generic;
using HelloMVC.Models;

namespace HelloMVC.Models.ViewModels
{
    public class CustomersProductsViewModels
    {
        public IEnumerable<Customer> GetCustomers { get; set; }
        public IEnumerable<Product> GetProducts { get; set; }

    }
}
