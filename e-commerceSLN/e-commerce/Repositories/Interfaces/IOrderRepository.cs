using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(int id);
        public Order GetById(int id);
        public int GetCount();
        public List<Order> GetAll();
        public Order GetByCustomerId(int id);
        public Order GetByStatus(Enum status); // Check 
        public void Save();

    }
}
