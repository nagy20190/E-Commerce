using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IOrderItemRepository
    {
        public void Add(OrderItem orderItem);
        public void Update(OrderItem orderItem);
        public List<OrderItem> GetAll();
        public void Delete(int id);
        public OrderItem GetById(int id);
        public OrderItem GetByProductId(int id);
        public void Save();

    }
}
