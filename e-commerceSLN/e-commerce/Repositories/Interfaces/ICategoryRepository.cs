using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public Category GetById(int id);
        public List<Category> GetByName(string name);
        public List<Category> GetAll();
        public void Save();
    }
}
