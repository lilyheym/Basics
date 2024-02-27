using Microsoft.AspNetCore.Mvc;

namespace CoreWebMVC1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
