using e_commerce.Models;

namespace e_commerce.ViewModels
{
    public class ProductWithCategoryVM
    {
        public List<Product> Products { get; set; }
        public List<Category> categories { get; set; }

    }
}
