using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class ProductController : Controller
    {
        [Route("test")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
