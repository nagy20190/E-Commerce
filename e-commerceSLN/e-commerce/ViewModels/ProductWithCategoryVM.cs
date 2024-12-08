using e_commerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace e_commerce.ViewModels
{
    public class ProductWithCategoryVM
    {

        public int productId { get; set; }
        public int categoryId { get; set; }
        public string? categoryName { get; set; }
        public int stockQuantity { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string productName { get; set; }

        public SelectList categories;

    }
}
