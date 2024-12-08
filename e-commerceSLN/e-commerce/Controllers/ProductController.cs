using e_commerce.Contexts;
using e_commerce.Models;
using e_commerce.Repositories.Interfaces;
using e_commerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection
        IProductRepository productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        // get all products for admin
        public IActionResult Index() // 
        {
            //ProductWithCategoryVM productWithCategoryVM = new ProductWithCategoryVM();
            return View("Index", productRepository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(new Product { Id = id });
        }


    }
}
