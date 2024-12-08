using e_commerce.Contexts;
using e_commerce.Models;
using e_commerce.Repositories.Interfaces;
using e_commerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ILogger<ProductController> logger;
        public ProductController(IProductRepository _productRepository,
            ICategoryRepository _categoryRepository, ILogger<ProductController> _logger)
        {
            productRepository = _productRepository;
            categoryRepository = _categoryRepository;
            logger = _logger;
        }

        // admin CRUD Operations
        public IActionResult Index() // Done
        {
            //ProductWithCategoryVM productWithCategoryVM = new ProductWithCategoryVM();
            return View("Index", productRepository.GetAll());
        }
        // Done
        public IActionResult Details(int id)
        {
            ProductWithCategoryVM productWithCategoryVM = new ProductWithCategoryVM();

            Product product = productRepository.GetById(id);
            Category category = categoryRepository.GetById(product.CategoryId);

            productWithCategoryVM.productId = product.Id;
            productWithCategoryVM.productName = product.Name;
            productWithCategoryVM.price = product.Price;
            productWithCategoryVM.description = product.Description;
            productWithCategoryVM.stockQuantity = product.StockQuantity;
            productWithCategoryVM.categoryName = category.Name;
            productWithCategoryVM.categoryId = category.Id;

            return View(productWithCategoryVM);
        }

        public IActionResult Edit(int id)
        {
            Product product = productRepository.GetById(id);
            var categories = categoryRepository.GetAll();
            var categorySelectList = new SelectList(categories, "Id", "Name", product.CategoryId);

            ProductWithCategoryVM productWithCategoryVM = new ProductWithCategoryVM();
            productWithCategoryVM.productId = product.Id;
            productWithCategoryVM.categoryId = product.CategoryId;
            productWithCategoryVM.productName = product.Name;
            productWithCategoryVM.description = product.Description;
            productWithCategoryVM.price = product.Price;
            productWithCategoryVM.stockQuantity = product.StockQuantity;
            productWithCategoryVM.categories = categorySelectList;

            return View("Edit", productWithCategoryVM);
        }

        // what i will do tommorow 
        /*
         2 - Auto Mapper -->  
         3 - Concurrency Handling:
            Consider handling concurrency (e.g., if another user updates the record simultaneously) using tracking or timestamps.
         */

        public IActionResult saveEdit(int id, ProductWithCategoryVM productFromRequst)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Product productFromDb = productRepository.GetById(id);
                    List<Category> categories = categoryRepository.GetAll();

                    if (productFromDb == null)
                    {
                        logger.LogWarning("Product with ID {ProductId} not found.", productFromRequst.productId);
                        return NotFound(); // Return a 404 if the product doesn't exist
                    }
                    //productFromDb.Id = productFromRequst.productId;
                    productFromDb.Name = productFromRequst.productName;
                    productFromDb.Description = productFromRequst.description;
                    productFromDb.Price = productFromRequst.price;
                    productFromDb.StockQuantity = productFromRequst.stockQuantity;
                    productFromDb.CategoryId = productFromRequst.categoryId;

                    productRepository.Update(productFromDb);
                    productRepository.Save();

                    logger.LogInformation("Product with ID {ProductId} was successfully updated.", productFromRequst.productId);

                    return RedirectToAction("Index"); // if success, return it to index
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while updating the product with ID {ProductId}.", productFromRequst.productId);
                    ModelState.AddModelError("", "An unexpected error occurred. Please try again.");
                    // Return a user-friendly error page or message
                    return View("Error", new ErrorViewModel { RequestId = productFromRequst.productId.ToString() });
                }
            }
            logger.LogWarning("Validation failed while updating product with ID {ProductId}.", productFromRequst.productId);
            productFromRequst.categories = new SelectList(categoryRepository.GetAll() ?? new List<Category>(), "Id", "Name");
            return View("Edit", productFromRequst);
        }




    }
}