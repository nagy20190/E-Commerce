using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        public void Add(Payment payment);
        public void Update(Payment payment);
        public void Delete(int id);
        public Payment GetById(int id);
        public Payment GetByOrderID(int orderID);
        public Payment GetByCustomerId(int customerId);
        public List<Payment> GetAll();
        public void Save();
    

    }
}
