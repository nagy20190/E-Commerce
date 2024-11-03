using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
        public Product GetById(int id);
        public List<Product> GetByName(string name);
        public List<Product> GetAll();
        public List<Product> GetProductsByCatId(int categId);
        public void Save();
    }
}
