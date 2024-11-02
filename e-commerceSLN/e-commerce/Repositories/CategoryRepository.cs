using e_commerce.Contexts;
using e_commerce.Models;
using e_commerce.Repositories.Interfaces;

namespace e_commerce.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ECommerceContext context;
        public CategoryRepository(ECommerceContext _context)
        {
            context = _context;
        }
        public void Add(Category category)
        {
           context.Add(category);
        }
        public void Delete(int id)
        {
            Category category = GetById(id);
            context.Remove(category);
        }

        public List<Category> GetAll()
        {
            return context.categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.categories.FirstOrDefault(c=>c.Id == id);
        }
        public List<Category> GetByName(string name)
        {
            return context.categories.Where(c=>c.Name.Contains(name)).ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Update(Category category)
        {
            context.Update(category);
        }
    }
}
