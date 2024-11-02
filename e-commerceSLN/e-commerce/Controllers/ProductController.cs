using e_commerce.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        ECommerceContext context = new ECommerceContext();
        public IActionResult Index()
        {
            return View("Index", context.products.ToList());
        }


    }
}
