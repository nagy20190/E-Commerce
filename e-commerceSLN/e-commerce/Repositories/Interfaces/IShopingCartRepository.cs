using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IShopingCartRepository
    {
        public void Add(ShoppingCart shoppingCart);
        public void Update(ShoppingCart shoppingCart);
        public void Delete(int id);
        public ShoppingCart GetById(int id);
        public List<ShoppingCart> GetAll();
        public ShoppingCart GetByCustomerId(int customerId);
        public void Save();

    }
}
