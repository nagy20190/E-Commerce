using e_commerce.Contexts;
using e_commerce.Models;
using e_commerce.Repositories.Interfaces;

namespace e_commerce.Repositories
{
    public class ProductRepository : IproductRepository
    {
        ECommerceContext context;
        public ProductRepository(ECommerceContext _context)
        {
            context = _context;
        }

        public void Add(Product product)
        {
            context.Add(product);
        }
        public void Delete(int id)
        {
            Product product = GetById(id);
            context.Remove(product);
        }
        public List<Product> GetAll()
        {
            return context.products.ToList();
        }
        public Product GetById(int id)
        {
            return context.products.FirstOrDefault(p => p.Id == id);
        }
        public List<Product> GetByName(string name)
        {
            return context.products.Where(p => p.Name.Contains(name)).ToList();
        }
        public List<Product> GetProductByCatId(int categId)
        {
            return context.products.Where(p => p.CategoryId == categId).ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Update(Product product)
        {
            context.Update(product);
        }
    }
}
