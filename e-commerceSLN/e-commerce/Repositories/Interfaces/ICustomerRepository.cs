using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        public void Add();
        public void Update(Customer customer);
        public void Delete(int id);
        public Customer GetById(int id);
        public List<Customer> GetAll();
        public Customer GetByUserName(string name);
        public Customer GetByEmail(string email);
        public void Save();

    }
}
