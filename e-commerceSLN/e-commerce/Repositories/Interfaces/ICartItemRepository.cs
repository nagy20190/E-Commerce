using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface ICartItemRepository
    {
        public void Add(CartItem cartItem);
        public void Update(CartItem cartItem);
        public void Delete(int id);
        public void DeleteAll();
        public CartItem GetById(int id);
        public List<CartItem> GetAll();
        public void Save();
    }
}
